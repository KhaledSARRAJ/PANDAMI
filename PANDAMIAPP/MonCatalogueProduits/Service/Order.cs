using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    public class Order
    {
        
        public int OrderId { get; set; }

        public List<OrderDetail> OrderLines { get; set; }
        public string NomUtilisateur { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime OrderPlaced { get; set; }
    }
}
