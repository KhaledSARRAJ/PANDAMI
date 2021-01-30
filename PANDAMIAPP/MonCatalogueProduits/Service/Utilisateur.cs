using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table("UTILISATEUR")]
    public class Utilisateur
    {
        [Key]
        public int UtilisateurID { get; set; }
        //   [Required(AllowEmptyStrings =false, ErrorMessage ="Ce champs est obligatoire.")]
        //  [Display(Name = "Votre nom")]
        public string Nom { get; set; }
        //  [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public string Prenom { get; set; }
        // [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public DateTime DateDeNaissance { get; set; }
        // [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public string NomUtilisateur { get; set; }
        //  [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public string AdresseMail { get; set; }

        public string DateInscription { get; set; }
        public string NumTel { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public string NomDeRue { get; set; }
        // [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        public string NumeroRue { get; set; }
        //  [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        // [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
        public string sexe { get; set; }
        public string autreContact { get; set; }
        public string Ville { get; set; }
        public string Region { get; set; }
        // [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est obligatoire.")]
        //// [DataType(DataType.Password)]
        ///  [Compare("MotDePasse", ErrorMessage ="Mot de passe et ce champs doit être le même")]
        public string confirmMotPasse { get; set; }
        public string SuccessMessage { get; set; }
        public string codePostal { get; set; }
        public string DateDeDesinscription { get; set; }
        public int identifiantSexeUser { get; set; }
        [ForeignKey("SexeID")]
        public ReferenctielSexe UtilisateurSexe { get; set; }
      
        public int identifiantMotifDesinscription { get; set; }
        [ForeignKey("MotifDesinscriptionID")]
        public MotifDesinscription UtilisateurMotifDesinscription { get; set; }
        public int IdentifiantReferentielVille { get; set; }
        [ForeignKey("VilleID")]
        public ReferentielVille UtilisateurReferentielVille { get; set; }



        public virtual ICollection<Demande> UtilisateurDemande { get; set; }
        public virtual ICollection<Reponse> UtilisateurReponse { get; set; }
        public virtual ICollection<Satisfaction> UtilisateurSatisfaction { get; set; }
        public virtual ICollection<Concertation> UtilisateurConcertation { get; set; }
        public virtual ICollection<Indisponibilite> UtilisateurIndisponibilite { get; set; }
        public virtual ICollection<PreferenceDomaine> UtilisateurPreferenceDomaine { get; set; }
        public virtual ICollection<PreferenceJourHoraire> UtilisateurPreferenceJourHoraire { get; set; }
        public virtual ICollection<PreferenceRayonAction> UtilisateurPreferenceRayonAction { get; set; }






    }
}
