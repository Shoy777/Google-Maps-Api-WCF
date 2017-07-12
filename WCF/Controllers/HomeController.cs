using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.Models;
using WCF.PersonaServiceReference;

namespace WCF.Controllers
{
    public class HomeController : Controller
    {
        private PersonaServiceClient PersonService = new PersonaServiceClient();//WCF Cliente
        private PersonaEntity personaModel = new PersonaEntity();//Modelo Cliente
        private Persona per = new Persona();//Modelo WCF
        
        public ActionResult Index(int id = 0)
        {
            var personaId = GetPersona(id);
            ViewBag.Listado = PersonService.GetAllPersonas().ToList();

            if (id < 1 || personaId == null)
            {
                ViewBag.Crud = "Registrar";
                return View(personaModel);
            }
            else
            {
                ViewBag.Crud = "Modificar";
                return View(GetPersona(id));
            }
        }
        
        [HttpPost]
        public ActionResult Index(PersonaEntity p)
        {
            if (ModelState.IsValid)
            {
                var persona = GetPersona(p.Nombre, p.Apellido);

                if (p.Id == 0)
                {
                    ViewBag.Crud = "Registrar";

                    if (persona != null)
                    {
                        ViewBag.Message = "Ya hay una Persona con los mismos datos";
                    }
                    else
                    {
                        per.Id = p.Id;
                        per.Apellido = p.Apellido;
                        per.Nombre = p.Nombre;
                        per.FechaNacimiento = p.FechaNacimiento;
                        per.CX = p.CX;
                        per.CY = p.CY;

                        bool register = PersonService.CreatePersona(per);

                        if(register){
                            ViewBag.Message = "Se Registró Persona";
                        }
                        else
                        {
                            ViewBag.Message = "Parece que no se ha registrado";
                        }
                    }
                }
                else
                {
                    ViewBag.Crud = "Modificar";
                    if (persona != null && persona.Id != p.Id)
                    {
                        ViewBag.Message = "Ya hay una Persona con los mismos datos";
                    }
                    else
                    {
                        per.Id = p.Id;
                        per.Apellido = p.Apellido;
                        per.Nombre = p.Nombre;
                        per.FechaNacimiento = p.FechaNacimiento;
                        per.CX = p.CX;
                        per.CY = p.CY;

                        bool edit = PersonService.EditPersona(per);

                        if (edit)
                        {
                            ViewBag.Message = "Se Grabaron los cambios";
                        }
                        else
                        {
                            ViewBag.Message = "Parece que no se ha modificado";
                        }
                        
                    }
                }
                ViewBag.Listado = PersonService.GetAllPersonas().ToList();
                return View("Index", p);
            }
            else
            {
                if (p.Id == 0)
                    ViewBag.Crud = "Registrar";
                else
                    ViewBag.Crud = "Modificar";

                ViewBag.Message = "Aún no ha terminado de llenar los campos";
                ViewBag.Listado = PersonService.GetAllPersonas().ToList();
                return View("Index", p);
            }
        }
        public ActionResult Delete(int id = 0)
        {
            var personaId = GetPersona(id);
            if (personaId == null)
            {
                ViewBag.Crud = "Eliminar";
                ViewBag.Message = "No se encontró Persona";
            }
            else
            {
                PersonService.DeletePersona(personaId.Id);
                ViewBag.Crud = "Eliminado";
                ViewBag.Message = "Se eliminó Persona";
            }
            ViewBag.Listado = PersonService.GetAllPersonas().ToList();
            return View("Index", personaId);
        }

        public PersonaEntity GetPersona(int id)
        {
            var data = PersonService.GetPersona(id);

            if (data == null)
            {
                return null;
            }
            else
            {
                return new PersonaEntity
                {
                    Id = data.Id,
                    Apellido = data.Apellido,
                    Nombre = data.Nombre,
                    FechaNacimiento = data.FechaNacimiento,
                    CX = data.CX,
                    CY = data.CY
                };
            }
        }

        public PersonaEntity GetPersona(string nombre, string apellido)
        {
            var data = PersonService.GetAllPersonas()
                .Where(p => p.Nombre.Equals(nombre) && p.Apellido.Equals(apellido))
                .FirstOrDefault();

            if (data == null)
            {
                return null;
            }
            else
            {
                return new PersonaEntity
                {
                    Id = data.Id,
                    Apellido = data.Apellido,
                    Nombre = data.Nombre,
                    FechaNacimiento = data.FechaNacimiento,
                    CX = data.CX,
                    CY = data.CY
                };
            }
        }

    }
}