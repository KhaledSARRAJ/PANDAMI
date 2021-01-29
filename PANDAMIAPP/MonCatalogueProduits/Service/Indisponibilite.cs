using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table("INDISPONIBILITE")]
    public class Indisponibilite
    {
        [Key]
        public int indispoID { get; set; }
        public DateTime dateDebutIndispo { get; set; }
        public DateTime dateFinIndispo { get; set; }
    public string CommentaireIndispo { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur IndisponibiliteUtilisateur { get; set; }
    }
}
