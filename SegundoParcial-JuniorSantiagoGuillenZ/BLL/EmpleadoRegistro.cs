using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using Entidad;

namespace BLL
{
    public class EmpleadoRegistro
    {
        public EmpleadoRegistro()
        {
            
         
        }
        DbRecursosHumanos db = new DbRecursosHumanos();
        public void Eliminar(int id)
        {
            Empleados em = (from a in db.Empleados
                            where a.IdEmpleado == id
                            select a).FirstOrDefault();

            db.Empleados.Remove(em);
            db.SaveChanges();

            
        }
        public void Actualizar(int id,string nombre,string direccion,string telefono,string celular,string cedula,string cargo,float sueldo,float incetivo)
        {
            Empleados em = (from e in db.Empleados
                            where e.IdEmpleado == id
                            select e).FirstOrDefault();
            em.Nombres = nombre;
            em.Direccion = direccion;
            em.Telefono = telefono;
            em.Celular = celular;
            em.Cedula = cedula;
            em.Cargo = cargo;
            em.Sueldo = sueldo;
            em.Incentivo = incetivo;

            db.SaveChanges();
        }
        public void Crear(string nombre, string direccion, string telefono, string celular, string cedula, string cargo, float sueldo,float incentivo)
        {
            Empleados em = new Empleados()
            {
                Nombres = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Celular = celular,
                Cedula = cedula,
                Cargo = cargo,
                Sueldo = sueldo,
                Incentivo = incentivo    
                

            };

            db.Empleados.Add(em);
            db.SaveChanges();
        }
        public Empleados Buscar(int id)
        {
            var db = new DbRecursosHumanos();

            return db.Empleados.Find(id);

        }
        public static List<Empleados>Lista()
        {
            
            var dbs = new DbRecursosHumanos();
          
            List<Empleados> lista = new List<Empleados>();          
            lista = dbs.Empleados.ToList();

            return lista;
        }
      
    }
}
