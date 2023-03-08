using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prueba2Parcial.Models;
using Prueba2Parcial.Models.TableViewModels;
using Prueba2Parcial.Models.ViewModels;

namespace Practica2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<PersonaTableViewModel> lst = null;

            using (db_personaEntities db = new db_personaEntities())
            {
                lst = (from d in db.tbl_persona
                       select new PersonaTableViewModel
                       {
                           CustomerId = d.customerId,
                           CustomerName = d.customerName,
                           ContactName = d.contactName,
                           Address = d.address,
                           City = d.city,
                           PostalCode = (int) d.postalCode,
                           Country = d.country
                       }).ToList();
            }
            return View(lst);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(PersonaViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            using (db_personaEntities db = new db_personaEntities())
            {
                tbl_persona oPersona = new tbl_persona();

                oPersona.customerName = model.CustomerName;
                oPersona.contactName = model.ContactName;
                oPersona.address = model.Address;
                oPersona.city = model.City;
                oPersona.postalCode = model.PostalCode;
                oPersona.country = model.Country;

                db.tbl_persona.Add(oPersona);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Persona/"));
        }

        public ActionResult Editar(int id)
        {
            EditarPersonaViewModels model = new EditarPersonaViewModels();
            using (db_personaEntities db = new db_personaEntities())
            {
                var oPersona = db.tbl_persona.Find(id);
                model.CustomerId = oPersona.customerId;
                model.CustomerName = oPersona.customerName;
                model.ContactName = oPersona.contactName;
                model.Address = oPersona.address;
                model.City = oPersona.city;
                model.PostalCode = (int) oPersona.postalCode;
                model.Country = oPersona.country;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(EditarPersonaViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            using (db_personaEntities db = new db_personaEntities())
            {
                var oPersona = db.tbl_persona.Find(model.CustomerId);
                oPersona.customerName = model.CustomerName;
                oPersona.contactName = model.ContactName;
                oPersona.address = model.Address;
                oPersona.city = model.City;
                oPersona.postalCode = model.PostalCode;
                oPersona.country = model.Country;
                db.Entry(oPersona).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Persona/"));
        }

        public ActionResult Eliminar(int id)
        {
            using (db_personaEntities db = new db_personaEntities())
            {
                var oPersona = db.tbl_persona.Find(id);
                db.tbl_persona.Remove(oPersona);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Persona/"));
        }

    }
}