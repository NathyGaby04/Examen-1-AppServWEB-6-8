using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vehiculos_ITM.Models;
using System.Data.Entity.Migrations;

namespace Vehiculos_ITM.Clases
{
    public class ClVehiculo
    {
        private DB_vehiculos_itmEntities dBVehiculosItm = new DB_vehiculos_itmEntities();
        public Vehiculo vehiculo { get; set; }
        public string Insertar()
        {
            try
            {
                dBVehiculosItm.Vehiculoes.Add(vehiculo);
                dBVehiculosItm.SaveChanges();
                return "Vehiculo insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el vehiculo: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                Vehiculo vhl = Consultar(vehiculo.Id);
                if (vhl == null)
                {
                    return "El vehiculo con el id ingresado no existe, por lo tanto no se puede actualizar";
                }
                dBVehiculosItm.Vehiculoes.AddOrUpdate(vehiculo);
                dBVehiculosItm.SaveChanges();
                return "Se actualizó el vehiculo correctamente";
            }
            catch (Exception ex)
            {
                return "No se pudo actualizar el vehiculo: " + ex.Message;
            }
        }

        public List<Vehiculo> ConsultarTodos()
        {
            return dBVehiculosItm.Vehiculoes
                .OrderBy(e => e.Id)
                .ToList();
        }
        public Vehiculo Consultar(int id)
        {
            return dBVehiculosItm.Vehiculoes.FirstOrDefault(e => e.Id == id);
        }
        public string Eliminar(int id)
        {
            try
            {
                Vehiculo vhl = Consultar(id);
                if (vhl == null)
                {
                    return "El vehiculo con el id ingresado no existe, por lo tanto no se puede eliminar";
                }

                dBVehiculosItm.Vehiculoes.Remove(vhl);
                dBVehiculosItm.SaveChanges();
                return "Se eliminó el vehiculo correctamente";
            }
            catch (Exception ex)
            {
                return "No se pudo eliminar el vehiculo: " + ex.Message;
            }
        }

    }    
}