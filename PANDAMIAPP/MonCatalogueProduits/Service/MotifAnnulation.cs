using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table ("MOTIANNULATION")]
    public class MotifAnnulation
    {
        [Key]
        public int MotifAnnulationID { get; set; }
        public string  LibelleMotifAnnul { get; set; }
        public virtual ICollection<Demande> MotifsAnnulationsDemande { get; set; }



    }
}
