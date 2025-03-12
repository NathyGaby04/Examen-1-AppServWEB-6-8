using Vehiculos_ITM.Clases;
using Vehiculos_ITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Vehiculos_ITM.Controllers
{
    [RoutePrefix("api/Vehiculos")]
    public class VehiculosController : ApiController
    {
        [HttpGet] 
        [Route("ConsultarTodos")] 
        public List<Vehiculo> ConsultarTodos()
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            return Vehiculo.ConsultarTodos();
        }
        [HttpGet]
        [Route("ConsultarXId")]
        public Vehiculo ConsultarXId(int id)
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            return Vehiculo.Consultar(id);
        }
        [HttpGet]
        [Route("ConsultarXMarca")]
        public List<Vehiculo> ConsultarXMarca(int Marca)
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            return Vehiculo.ConsultarMarca(Marca);
        }
        [HttpGet]
        [Route("ConsultarXNombre")]
        public Vehiculo ConsultarXNombre(string Nombre)
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            return Vehiculo.Consultar(Nombre);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vehiculo vhl)
        {
            
            ClVehiculo Vehiculo = new ClVehiculo();
            Vehiculo.vehiculo = vhl;   
            return Vehiculo.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vehiculo vhl)
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            Vehiculo.vehiculo = vhl;
            return Vehiculo.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            ClVehiculo Vehiculo = new ClVehiculo();
            return Vehiculo.Eliminar(id);
        }
    }
}