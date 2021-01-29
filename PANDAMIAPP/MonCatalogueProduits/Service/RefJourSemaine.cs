using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table("REFJOURSEMAINE")]
    public class RefJourSemaine
    {
        [Key]
        public int JourSemaineID { get; set; }
        public string LibelleJourSemaine { get; set; }
        public virtual ICollection<PreferenceJourHoraire> RefJourSemainePreferenceJourHoraire{get;set;}
    }
}
