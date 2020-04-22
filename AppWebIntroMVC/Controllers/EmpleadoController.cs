using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioServicio.Servicios;
using DominioServicio.Entidades;
namespace AppWebIntroMVC.Controllers
{


    public class EmpleadoController : Controller
    {

        ServicioEmpleado se = new ServicioEmpleado();
        // GET: Empleado
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Crear(FormCollection form )
        //{
        //    Empleado em = new Empleado();

        //    em.Nombre = form["Nombre"];
        //    em.Apellido = form["Apellido"];

        //    se.Nuevo(em);

        //    return RedirectToAction("Listar");
        
        //}

        [HttpPost]
        public ActionResult Crear(Empleado em)
        {
            //Empleado em = new Empleado();

            //em.Nombre = form["Nombre"];
            //em.Apellido = form["Apellido"];

            se.Nuevo(em);

            return RedirectToAction("Listar");

        }




        public ActionResult Buscar(int id=0)
        {
            ServicioEmpleado se = new ServicioEmpleado();

            var em = se.BuscarPorId(id);

            return View(em);

        }

        public ActionResult Listar()
        {
            //ViewBag.TodosEmpleados = 
            List<Empleado> listaEmp = se.ListarTodos();
            
        
            return View(listaEmp);

        }





     
    }
}