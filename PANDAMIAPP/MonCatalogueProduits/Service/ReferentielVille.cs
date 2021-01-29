using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table("REFERENTIELVILLE")]
    public class ReferentielVille
    {
        [Key]
        public int VilleID { get; set; }
        public string LibelleVille { get; set; }
        [StringLength(100)]
        public int CodePostal { get; set; }
        [StringLength(5)]
        public int IdentifiantRegion { get; set; }
        [ForeignKey("RegionID")]

        public virtual ICollection<Demande>RefVilleDemandeaide { get; set; }
        public virtual ICollection<Concertation> VilleConecertation{get;set;}
        public virtual ICollection<Utilisateur> VilleUtilisateur { get; set; }
        public virtual ICollection<PreferenceRayonAction> RefVillePreferenceRayonAction { get; set; }
        
       
        
    }
}