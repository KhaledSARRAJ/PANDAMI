using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table ("REPONSE")]
    public class Reponse
    {
        [Key]
        public int ReponseID { get; set; }
        public DateTime DateReponse { get; set; }
        public DateTime DateRenonciation { get; set; }
        public DateTime DatePriseCompte { get; set; }
        public int DemandeID { get; set; }
        [ForeignKey ("DemandeID")]
        public Demande ReponseDemande { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur ReponseUtilisateur { get; set; }

    }
}
