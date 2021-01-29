using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table("MOTIFDESINSCRIPTION")]
    public class MotifDesinscription
    {
        [Key]
        public int MotifDesinscriptionID { get; set; }
        public string LibelleMotifDesinscr { get; set; }
    
    public virtual ICollection<Utilisateur> MotifDesinscriptionUtilisateur { get; set; }
    }
}
