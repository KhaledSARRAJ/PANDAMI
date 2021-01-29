using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table ("PREFERENCERAYONACTION")]
    public class PreferenceRayonAction
    {

        [Key]
        public int RayonActionID { get; set; }
        public int ValeurRayon { get; set; }
        public DateTime DateDebutChRay { get; set; }
        public DateTime DateFinChRay { get; set; }

        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur PreferenceRayonActionUtilisateur{ get; set; }


    }
}
