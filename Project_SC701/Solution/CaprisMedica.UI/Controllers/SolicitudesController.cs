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
   
    public class SolicitudesController : Controller
    {
        private string URL = "http://localhost:51780/";

        // GET: Solicitudes1
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            List<Models.Solicitudes> aux = new List<Models.Solicitudes>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Solicitude");
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.Solicitudes>>(auxR);
                }
                //var aRMContext = _context.Solicitudes.Include(s => s.Cliente).Include(s => s.Departamento).Include(s => s.EmpleadoCedulaNavigation).Include(s => s.Equipo).Include(s => s.Provincia).Include(s => s.TipoTrabajo);
                //return View(await aRMContext.ToListAsync());
                return View(aux);
            }
        }

        // GET: Solicitudes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var solicitudes = await GetSolicitud(id);
            /*
            var solicitudes = await _context.Solicitudes
                .Include(s => s.Cliente)
                .Include(s => s.Departamento)
                .Include(s => s.EmpleadoCedulaNavigation)
                .Include(s => s.Equipo)
                .Include(s => s.Provincia)
                .Include(s => s.TipoTrabajo)
                .FirstOrDefaultAsync(m => m.SolicitudId == id);*/
            if (solicitudes == null)
            {
                return NotFound();
            }

            return View(solicitudes);
        }

        // GET: Solicitudes1/Create
        public IActionResult Create()
        {
            //ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteCorreo");
            //ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "DeparatamentoNombre");
            //ViewData["EmpleadoCedula"] = new SelectList(_context.Empleados, "EmpleadoCedula", "EmpleadoCedula");
            //ViewData["EquipoId"] = new SelectList(_context.Equipos, "EquipoId", "EquipoEstado");
            //ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "ProvinciaId", "ProvinciaNombre");
            //ViewData["TipoTrabajoId"] = new SelectList(_context.TipoTrabajo, "TipoTrabajoId", "TipoTrabajoEstado");
            return View();
        }

        // POST: Solicitudes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SolicitudId,ClienteId,EmpleadoCedula,TipoTrabajoId,DepartamentoId,EquipoId,SolicitudJefatura,FechaReporte,HoraEntrada,HoraSalida,TipoHora,CantidadHoras,SolicitudMotivo,MotivoDetalle,SolicitudRepuestos,EquipoDetenido,ProvinciaId,FirmaCliente")] Solicitudes solicitudes)
        {
            if (ModelState.IsValid)
            {
                using (var cl = new HttpClient())
                {
                    cl.BaseAddress = new Uri(URL);
                    var content = JsonConvert.SerializeObject(solicitudes);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage res = await cl.PostAsync("api/Solicitude", byteContent);
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            //ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteCorreo", solicitudes.ClienteId);
            //ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "DeparatamentoNombre", solicitudes.DepartamentoId);
            //ViewData["EmpleadoCedula"] = new SelectList(_context.Empleados, "EmpleadoCedula", "EmpleadoCedula", solicitudes.EmpleadoCedula);
            //ViewData["EquipoId"] = new SelectList(_context.Equipos, "EquipoId", "EquipoEstado", solicitudes.EquipoId);
            //ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "ProvinciaId", "ProvinciaNombre", solicitudes.ProvinciaId);
            //ViewData["TipoTrabajoId"] = new SelectList(_context.TipoTrabajo, "TipoTrabajoId", "TipoTrabajoEstado", solicitudes.TipoTrabajoId);
            ModelState.AddModelError(string.Empty, "Server Error");
            return View(solicitudes);
        }

        // GET: Solicitudes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudes = await GetSolicitud(id);
            if (solicitudes == null)
            {
                return NotFound();
            }
            //ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteCorreo", solicitudes.ClienteId);
            //ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "DeparatamentoNombre", solicitudes.DepartamentoId);
            //ViewData["EmpleadoCedula"] = new SelectList(_context.Empleados, "EmpleadoCedula", "EmpleadoCedula", solicitudes.EmpleadoCedula);
            //ViewData["EquipoId"] = new SelectList(_context.Equipos, "EquipoId", "EquipoEstado", solicitudes.EquipoId);
            //ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "ProvinciaId", "ProvinciaNombre", solicitudes.ProvinciaId);
            //ViewData["TipoTrabajoId"] = new SelectList(_context.TipoTrabajo, "TipoTrabajoId", "TipoTrabajoEstado", solicitudes.TipoTrabajoId);
            return View(solicitudes);
        }

        // POST: Solicitudes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SolicitudId,ClienteId,EmpleadoCedula,TipoTrabajoId,DepartamentoId,EquipoId,SolicitudJefatura,FechaReporte,HoraEntrada,HoraSalida,TipoHora,CantidadHoras,SolicitudMotivo,MotivoDetalle,SolicitudRepuestos,EquipoDetenido,ProvinciaId,FirmaCliente")] Solicitudes solicitudes)
        {
            if (id != solicitudes.SolicitudId)
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
                        var content = JsonConvert.SerializeObject(solicitudes);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        HttpResponseMessage res = await cl.PutAsync("api/Solicitude/" + id, byteContent);
                        if (res.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
                catch (Exception ee)
                {
                    var temp = await GetSolicitud(id);
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
            //ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteCorreo", solicitudes.ClienteId);
            //ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "DeparatamentoNombre", solicitudes.DepartamentoId);
            //ViewData["EmpleadoCedula"] = new SelectList(_context.Empleados, "EmpleadoCedula", "EmpleadoCedula", solicitudes.EmpleadoCedula);
            //ViewData["EquipoId"] = new SelectList(_context.Equipos, "EquipoId", "EquipoEstado", solicitudes.EquipoId);
            //ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "ProvinciaId", "ProvinciaNombre", solicitudes.ProvinciaId);
            //ViewData["TipoTrabajoId"] = new SelectList(_context.TipoTrabajo, "TipoTrabajoId", "TipoTrabajoEstado", solicitudes.TipoTrabajoId);
            return View(solicitudes);
        }

        // GET: Solicitudes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudes = await GetSolicitud(id);
            //var solicitudes = await _context.Solicitudes
            //    .Include(s => s.Cliente)
            //    .Include(s => s.Departamento)
            //    .Include(s => s.EmpleadoCedulaNavigation)
            //    .Include(s => s.Equipo)
            //    .Include(s => s.Provincia)
            //    .Include(s => s.TipoTrabajo)
            //    .FirstOrDefaultAsync(m => m.SolicitudId == id);
            if (solicitudes == null)
            {
                return NotFound();
            }

            return View(solicitudes);
        }

        // POST: Solicitudes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/Solicitude" + id);
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<Solicitudes> GetSolicitud(int? id)
        {
            Solicitudes aux = new Solicitudes();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(URL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Solicitude/" + id);
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Models.Solicitudes>(auxR);
                }
            }
            return aux;
        }
    }
}
