using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonCatalogueProduit.Service;

namespace GestionProduits.Controllers
{
    public class RegisterController : Controller
    {
        CatalogueDbContext db = new CatalogueDbContext();
        public ActionResult Index()
        {
            return View();
        }
       
    }
}