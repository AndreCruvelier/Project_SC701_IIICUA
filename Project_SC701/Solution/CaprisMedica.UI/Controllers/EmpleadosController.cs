using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CaprisMedica.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CaprisMedica.UI.Controllers
{

    public class EmpleadosController : Controller
    {
        string URL = "http://localhost:51780/";
        
        // GET: Empleados1
        public async Task<IActionResult> Index()
        {
            List<Models.Empleados> aux = new List<Models.Empleados>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Empleado");
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.Empleados>>(auxR);
                }
                return View(aux);
            }
        }

        // GET: Empleados1/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleados = await GetEmpleado(id);
            if (empleados == null)
            {
                return NotFound();
            }

            return View(empleados);
        }

        // GET: Empleados1/Create
        public IActionResult Create()
        {
            //ViewData["TipoId"] = new SelectList(_context.TipoCedula, "TipoId", "TipoDescripcion");
            return View();
        }

        // POST: Empleados1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("1,EmpleadoCedula,EmpleadoNombre,EmpleadoPrimerA,EmpleadoSegundoA,EmpleadoCorreo,EmpleadoEstado")] Empleados empleados)
        {
            if (ModelState.IsValid)
            {
                using (var cl = new HttpClient())
                {
                    cl.BaseAddress = new Uri(URL);
                    var content = JsonConvert.SerializeObject(empleados);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage res = await cl.PostAsync("api/Empleado", byteContent);

                    //cl.BaseAddress = new Uri(URL);
                    //var content = JsonConvert.SerializeObject(empleados);
                    //var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    //var byteContent = new ByteArrayContent(buffer);
                    //byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    //HttpResponseMessage res = await cl.GetAsync("api/Empleado");
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            //ViewData["TipoId"] = new SelectList(_context.TipoCedula, "TipoId", "TipoDescripcion", empleados.TipoId);
            ModelState.AddModelError(string.Empty, "Server Error");
            return View(empleados);
        }

        // GET: Empleados1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleados = await GetEmpleado(id);
            if (empleados == null)
            {
                return NotFound();
            }
            //ViewData["TipoId"] = new SelectList(_context.TipoCedula, "TipoId", "TipoDescripcion", empleados.TipoId);
            return View(empleados);
        }

        // POST: Empleados1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("1,EmpleadoCedula,EmpleadoNombre,EmpleadoPrimerA,EmpleadoSegundoA,EmpleadoCorreo,EmpleadoEstado")] Empleados empleados)
        {
            if (id != empleados.EmpleadoCedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using (var cl = new HttpClient())
                    {
                        cl.BaseAddress = new Uri(URL);
                        var content = JsonConvert.SerializeObject(empleados);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        HttpResponseMessage res = await cl.PutAsync("api/Empleado/" + id, byteContent);
                        if (res.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
                catch (Exception ee)
                {
                    var temp = await GetEmpleado(id);
                    if (temp == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["TipoId"] = new SelectList(_context.TipoCedula, "TipoId", "TipoDescripcion", empleados.TipoId);
            return View(empleados);
        }

        // GET: Empleados1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleados = await GetEmpleado(id);
            if (empleados == null)
            {
                return NotFound();
            }

            return View(empleados);
        }

        // POST: Empleados1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/Empleado" + id);
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<Empleados> GetEmpleado(string? id)
        {
            Empleados aux = new Empleados();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Empleado/" + id);
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Models.Empleados>(auxR);
                }
            }
            return aux;
        }
    }
}
