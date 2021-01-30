using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduits.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonCatalogueProduit.Service;

namespace GestionProduits.Controllers
{
    public class FormulaireController : Controller
    {
        public CatalogueDbContext dbContext { get; set; }
        public FormulaireController(CatalogueDbContext db)
        {
            this.dbContext = db;
        }
        public IActionResult SaveUtilisateur()
        {
            Utilisateur p = new Utilisateur();
            IEnumerable<Utilisateur> cats = dbContext.ListUtilisateurs;
            ViewBag.utilisateurs = cats;
            return View("SaveUtilisateur", p);

        }
        [HttpPost]
        public IActionResult SaveUtilisateur(Utilisateur p)
        {
            IEnumerable<Utilisateur> cats = dbContext.ListUtilisateurs;
            ViewBag.utilisateurs = cats;

            if (ModelState.IsValid)
            {
                dbContext.ListUtilisateurs.Add(p);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("", p);

        }
    }
}

