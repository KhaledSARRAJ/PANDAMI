using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using GestionProduits.Service;
using Microsoft.AspNetCore.Mvc;
using MonCatalogueProduit.Service;

namespace GestionProduits.Controllers
{
    public class AccountController : Controller
    {
        //CatalogueDbContext objUserDBEntities = new CatalogueDbContext();
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ActionResult Register()
        //{
        //    Utilisateur objUserModel = new Utilisateur();
        //    return View(objUserModel);
        //}
        //[HttpPost]
        //public ActionResult Register (Utilisateur objUserModel)
        //{
        //    if (ModelState.IsValid) { 
        //    Utilisateur objUser = new DbModel.Utilisateur();
        //    objUser.DateInscription = DateTime.Now;
        //    objUser.Nom = objUserModel.Nom;
        //    objUser.Prenom = objUserModel.Prenom;
        //    objUser.DateDeNaissance = objUserModel.DateDeNaissance;
        //    objUser.sexe = objUserModel.sexe;
        //    objUser.AdresseMail = objUserModel.AdresseMail;
        //    objUser.NumTel = objUserModel.NumTel;
        //    objUser.autreContact = objUserModel.autreContact;
        //    objUser.Region = objUserModel.Region;
        //    objUser.NomDeRue = objUserModel.NomDeRue;
        //    objUser.codePostal = objUserModel.codePostal;
        //    objUser.Ville = objUserModel.Ville;
        //    objUser.NomUtilisateur = objUserModel.NomUtilisateur;
        //    objUser.MotDePasse = objUserModel.MotDePasse;
        //    objUserDBEntities.ListUtilisateurs.Add(objUser);
        //    objUserDBEntities.SaveChanges();
        //        objUserModel.SuccessMessage = "Bien enregistrer";
        //        return View(objUserModel);
        //    }
        //    return View();
        public CatalogueDbContext dbContext { get; set; }
        public AccountController(CatalogueDbContext db)
        {
            this.dbContext = db;
        }
        public IActionResult Register()
        {
            Utilisateur p = new Utilisateur();
            IEnumerable<Utilisateur> cats = dbContext.ListUtilisateurs;
            ViewBag.utilisateurs = cats;
            return View("Register", p);

        }
        [HttpPost]
        public IActionResult Register(Utilisateur p)
        {
            IEnumerable<Utilisateur> cats = dbContext.ListUtilisateurs;
            ViewBag.utilisateurs = cats;

            if (ModelState.IsValid)
            {
                dbContext.ListUtilisateurs.Add(p);
                dbContext.SaveChanges();
                p = new Utilisateur();
                p.SuccessMessage = "Vous êtes bien enregistrer";
                return RedirectToAction("Index", "Home");
            }
            
            return View();

        }
        public IActionResult Login()
        {
            LoginModel p = new LoginModel();
            
            
            return View(p);

        }
        [HttpPost]
        public IActionResult Login(LoginModel p)
        {
            if (ModelState.IsValid)
            {
               if( dbContext.ListUtilisateurs.Where(m => m.AdresseMail == p.Email && m.MotDePasse == p.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Email and Password is not Matching");
                    return View();
                }
               else
                {
                   // Session["AdresseMail"] = p.Email;
                    RedirectToAction("Index", "Home");
                        }
            }

            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }

    }

}

