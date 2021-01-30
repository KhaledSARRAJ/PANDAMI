
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduits.Service.Interfaces;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CatalogueDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(CatalogueDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    DemandeID = shoppingCartItem.Demande.DemandeID,
                    IdentifiantOrder = order.OrderId,
                    
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }

}
