using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table ("PREFERENCEJOURETHORAIRE")]
    public class PreferenceJourHoraire
    {
        [Key]
        public int PreferenceJHID { get; set; }
        public string heureDebut { get; set; }
        public string  heurefin { get; set; }
        public DateTime DateDebutValidite { get; set; }
        public DateTime DateDeFinValidite { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur PreferenceJourHoraireUtilisateur { get; set; }        
        public int  IdentifiantJourSemaine { get; set; }
        [ForeignKey("JourSemaineID")]
        public RefJourSemaine PreferenceJourHoraireJourSemaine { get; set; }
        
    }
}
