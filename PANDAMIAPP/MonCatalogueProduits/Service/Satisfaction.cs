using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table("SATISFACTION")]
    public class Satisfaction
    {
        [Key]
        public int SatisfactionID { get; set; }
        public DateTime DateEvaluation { get; set; }
        public int NoteConformite { get; set; }
        [Required, Range(0, 10)]
        public int NoteRelation { get; set; }
        [Required, Range(0, 10)]
        public int NoteContact { get; set; }
        [Required, Range(0, 10)]
        public string Message { get; set; }
        [StringLength(500)]
        public int DemandeID { get; set; }
        [ForeignKey("DemandeID")]
        public Demande SatisfactionDemande { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur SatisfactionUtilisateur { get; set; }
    }
}
