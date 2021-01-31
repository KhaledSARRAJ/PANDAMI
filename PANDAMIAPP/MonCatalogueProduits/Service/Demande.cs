using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GestionProduits.Service;

namespace MonCatalogueProduit.Service
{
    [Table("DEMANDES")]  //Nom de table à manipuler
    public class Demande
    {
        [Key]
        public int DemandeID { get; set; }
        

        // [StringLength(70)] // taille 
        //[DataType(DataType.DateTime)]
        [Required]
        [MinLength(4), MaxLength(140)]
        public string DateEnregistrementDemande { get; set; }

        //[DataType(DataType.DateTime)]
        public DateTime DatedeRealisation { get; set; }
        public string heureSouhaitee { get; set; }
        [Required]
        [MinLength(1), MaxLength(140)]
        public string Description { get; set; }
        
        public string DateClotureDemande { get; set; }
        public string DateModification { get; set; }
        public string DateAnnulationDemande { get; set; }
        [Required]
        [StringLength(10)]
        public string Ville { get; set; }
        /*[Required]
        [StringLength(6)]*/
        public TimeSpan Horaire { get; set; }
       
        public string adressesecondaire { get; set; }
        public int CategoriesID { get; set; }
        [ForeignKey("CategoriesID")]
        public int IdentifiantMateriel{ get; set; }
        [ForeignKey("MaterielID")]
        public int IdentifiantMAnnulation { get; set; }
        [ForeignKey("MotifAnnulationID")]
        public int IdentifiantUtilisateur { get; set; }
        [ForeignKey("UtilisateurID")]
        public Utilisateur DemandeUtilisateur { get; set; }

        //lazy loading : eviter de charger les entités lièes en mèmoire sans en avoir besoin
        //include aprés pour l'appeler
        public virtual Categorie categorieDemande { get; set; }

        public virtual Materiel materiels { get; set; }
        public virtual ICollection<Reponse> DemandeReponse {get; set;}
        public virtual ICollection<Satisfaction> DemandeSatisfaction { get; set; }
        public virtual ICollection<Concertation> DemandeConcertation { get; set; }
        public virtual ICollection<Demande> RecurrenceDemande { get; set; }
    }
}
