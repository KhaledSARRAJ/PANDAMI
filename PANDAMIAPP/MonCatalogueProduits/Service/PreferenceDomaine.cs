using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table ("PREFERENCEDOMAINE")]
    public class PreferenceDomaine
    {
        [Key]
        public int PreferenceDomaineID { get; set; }
        public DateTime dateDebutPref { get; set; }
        public DateTime dateFinPref { get; set; }
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur PreferenceDomaineUtilisateur { get; set; }
        public int IdentifiantDomaineActiviter { get; set; }
        [ForeignKey("DomaineActID")]
        public Categorie PreferenceDomaineDomaineActivite { get; set; }

    }
}
