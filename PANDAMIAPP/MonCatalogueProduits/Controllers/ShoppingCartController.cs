
using GestionProduits.Service;
using GestionProduits.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MonCatalogueProduit.Service;
using System.Linq;

namespace GestionProduits.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly CatalogueDbContext _dbContext;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(CatalogueDbContext dbContext, ShoppingCart shoppingCart)
        {
            _dbContext = dbContext;
            _shoppingCart = shoppingCart;
        }

    
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

       
        public RedirectToActionResult AddToShoppingCart(int demandeId)
        {
            var selectedDemande = _dbContext.ListeDemandes.FirstOrDefault(p => p.DemandeID == demandeId);
            if (selectedDemande != null)
            {
                _shoppingCart.AddToCart(selectedDemande, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int demandeId)
        {
            var selectedDemande = _dbContext.ListeDemandes.FirstOrDefault(p => p.DemandeID == demandeId);
            if (selectedDemande != null)
            {
                _shoppingCart.RemoveFromCart(selectedDemande);
            }
            return RedirectToAction("Index");
        }

    }
}
