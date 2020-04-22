using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioServicio.Entidades;
namespace DominioServicio.Servicios
{
    public class ServicioEmpleado
    {
        private static List<Empleado> empleados;

        public ServicioEmpleado()
        {
            if (empleados == null)
            {
                empleados = new List<Empleado>()
                {
                    new Empleado(){  Apellido = "Ramirez", Nombre="Juan", Id=1  },
                    new Empleado() { Apellido = "Rodriguez", Nombre = "Gimena", Id = 2 }
                };
            }
        }


        public Empleado BuscarPorId(int id)
        {
            //Empleado em;

            foreach (Empleado em in empleados)
            {
                if (em.Id == id)
                {
                    return em;
                }
            }
            return new Empleado() { Id = 0 };
        }


        public List<Empleado> ListarTodos()
        {
            //Logica hacia la dal.

            return empleados;
        }

        public void Nuevo(Empleado em)
        {
            empleados.Add(em);
        }

    }

    }
