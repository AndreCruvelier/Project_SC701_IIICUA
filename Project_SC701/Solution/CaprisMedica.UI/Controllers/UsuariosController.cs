using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CaprisMedica.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CaprisMedica.UI.Controllers
{
    public class UsuariosController : Controller
    {
        //private readonly ARMContext _context;

        //public Usuarios1Controller(ARMContext context)
        //{
        //    _context = context;
        //}

        private string URL = "http://localhost:51780/";

        // GET: Usuarios1
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            List<Models.Usuarios> aux = new List<Models.Usuarios>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Usuario");
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.Usuarios>>(auxR);
                }
                //var aRMContext = _context.Usuarios.Include(u => u.Rol);
                return View(aux);
            }
        }

        // GET: Usuarios1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await GetUsuario(id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // GET: Usuarios1/Create
        public IActionResult Create()
        {
            //ViewData["RolId"] = new SelectList(_context.Roles, "RolId", "RolDescripcion");
            return View();
        }

        // POST: Usuarios1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usuario,RolId,UsuarioContraseña")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                using (var cl = new HttpClient())
                {
                    cl.BaseAddress = new Uri(URL);
                    var content = JsonConvert.SerializeObject(usuarios);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage res = await cl.PostAsync("api/Usuario", byteContent);
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            //ViewData["RolId"] = new SelectList(_context.Roles, "RolId", "RolDescripcion", usuarios.RolId);
            ModelState.AddModelError(string.Empty, "Server Error");
            return View(usuarios);
        }

        // GET: Usuarios1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await GetUsuario(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            //ViewData["RolId"] = new SelectList(_context.Roles, "RolId", "RolDescripcion", usuarios.RolId);
            return View(usuarios);
        }

        // POST: Usuarios1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Usuario,RolId,UsuarioContraseña")] Usuarios usuarios)
        {
            if (id != usuarios.Usuario)
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
                        var content = JsonConvert.SerializeObject(usuarios);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        HttpResponseMessage res = await cl.PutAsync("api/Usuario/" + id, byteContent);
                        if (res.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
                catch (Exception ee)
                {
                    var temp = await GetUsuario(id);
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
            //ViewData["RolId"] = new SelectList(_context.Roles, "RolId", "RolDescripcion", usuarios.RolId);
            return View(usuarios);
        }

        // GET: Usuarios1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await GetUsuario(id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // POST: Usuarios1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/Usuario" + id);
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<Usuarios> GetUsuario(string? id)
        {
            Usuarios aux = new Usuarios();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Usuario/" + id);
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Models.Usuarios>(auxR);
                }
            }
            return aux;
        }
    }
}
