using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table ("CONCERTATION")]
    public class Concertation
    {
        [Key]
        public int  ConcertationID { get; set; }
        public DateTime DateConcertation { get; set; }
        public string HoraireProposer { get; set; }
        [StringLength(5)]
        public DateTime DateProposer { get; set; }
        public string ComplementAdresse { get; set; }
        [StringLength(86)]
        public DateTime DateAcceptation { get; set; }
        public DateTime DateRejetDefinitif { get; set; }
        public int identifiantDemandeID{ get; set; }
        [ForeignKey("DemandeID")]
        public Demande ConcertationDemande { get; set; }
        public  ICollection<Concertation> SuivreConcertation { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur ConcertationUtilisateur { get; set; }
    }
}
