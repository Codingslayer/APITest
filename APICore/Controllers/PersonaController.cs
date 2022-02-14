using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private PruebaMVCContext _db;

        public PersonaController(PruebaMVCContext db)
        {
            _db = db;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public ActionResult Get()
        {
            var lst = _db.Tblciudads.ToList();

            return Ok(lst);
        }

        // POST api/<PersonaController>
        [HttpPost]
        public ActionResult Post([FromBody] Models.Tblciudad model)
        {
            var ciudad = new Tblciudad();
            ciudad.Nombre = model.Nombre;

            _db.Tblciudads.Add(ciudad);
            _db.SaveChanges();

            return Ok();
        }

        // PUT api/<PersonaController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Models.Tblciudad model)
        {
            var ciudad = _db.Tblciudads.Find(model.Id);
            ciudad.Nombre = model.Nombre;

            _db.Entry(ciudad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();

            return Ok();
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Tblciudad model)
        {
            var ciudad = _db.Tblciudads.Find(model.Id);
            _db.Tblciudads.Remove(ciudad);
            _db.SaveChanges();

            return Ok();
        }
    }
}
