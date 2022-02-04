using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using APItest.Models;
using APItest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace APItest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ConsultaController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly string conexion = "";

        public ConsultaController(IConfiguration config)
        {
            this.config = config;
            conexion = config.GetConnectionString("Connection");
        }

        /// <summary>
        /// Metodo de consulta para mostrar personas
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Parametros parametros)
        {
            try
            {
                DataSet ds = Consulta.Query(parametros, conexion);
                
                    var data = new
                    {
                        nombre = ds.Tables[1],
                        apellido = ds.Tables[2],
                        ciudad = ds.Tables[3],
                        telefono = ds.Tables[4],
                        edad = ds.Tables[5],
                        activo = ds.Tables[6]
                    };
                
                    return Ok(JsonConvert.SerializeObject(ds.Tables[0]));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}