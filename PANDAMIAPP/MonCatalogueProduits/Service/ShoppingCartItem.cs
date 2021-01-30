using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Demande Demande { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
