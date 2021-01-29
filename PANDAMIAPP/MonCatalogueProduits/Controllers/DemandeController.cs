using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduits.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonCatalogueProduit.Service;

namespace GestionProduits.Controllers
{
    public class DemandeController : Controller
    {
        public CatalogueDbContext dbContext { get; set; }
        public DemandeController(CatalogueDbContext db)
        {
            this.dbContext = db;
        }
        public IActionResult Index(int page=0, int size =6, string motCle="")
        {

            int position = page * size;
            IEnumerable<Demande> demandes = dbContext
                .ListeDemandes
                .Where(p=>p.Description.Contains(motCle))
                .Skip(position)
                .Take(size)
                .Include(p=>p.categorieDemande)
                .ToList();
            ViewBag.currentPage = page;
            int nbDemandes = 
                dbContext
                .ListeDemandes
                .Where(p => p.Description.Contains(motCle))
                .ToList().Count;
            int totalPages;
            if ((nbDemandes % size) == 0) {
                totalPages = nbDemandes / size;
            }
            else
            {
                totalPages = 1+(nbDemandes / size);
            }
            ViewBag.motCle = motCle;

            ViewBag.totalPages = totalPages;
            return View("Demandes",demandes);
        }
        public IActionResult FormDemande()
        {
            Demande p = new Demande();
            IEnumerable<Categorie> cats = dbContext.ListeCategories.ToList();
            ViewBag.categories = cats;
            return View("FormDemande",p);
        }
        [HttpPost]
            public IActionResult SaveDemande(Demande p)
        {
            if (ModelState.IsValid) {                     
            dbContext.ListeDemandes.Add(p);
            dbContext.SaveChanges();
            return RedirectToAction("Index"); //retour à l'index apres l'enregistrement
            }
            IEnumerable<Categorie> cats = dbContext.ListeCategories.ToList();
            ViewBag.categories = cats;
            return View("FormDemande",p);

        }

        [HttpGet]  //optionnelle
        public ActionResult Delete(int id)
        {
            Demande d = new Demande();
            d.DemandeID = id;
            dbContext.ListeDemandes.Remove(d);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Editer(int id)
        {
            Demande d = new Demande();
            d.DemandeID = id;
            IEnumerable<Categorie> cats = dbContext.ListeCategories.ToList();
            ViewBag.categories = cats;
            return View("DemandeFormEdit", d);
        }

        public ActionResult Update(Demande p)
        {
            if (ModelState.IsValid)
            {
              IEnumerable<Categorie> cats = dbContext.ListeCategories.ToList();
               ViewBag.categories = cats;
                dbContext.ListeDemandes.Update(p);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("DemandeFormEdit");
            }
        }

    }
}
