using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int IdentifiantOrder { get; set; }
        [ForeignKey ("OrderId")]
        public int Amount { get; set; }
        public int DemandeID { get; set; }
        public virtual Demande Demande { get; set; }
        public virtual Order Order { get; set; }
    }
}
