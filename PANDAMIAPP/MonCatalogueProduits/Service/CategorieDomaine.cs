using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table("CATDOMAINE")] //c'est le nom de table à manipuler      
    public class CategorieDomaine
    {
            [Key]
            public int CategorieDomaineID { get; set; }
            [StringLength(30)]       //pour spécifier la taille à modifier
            public string libelleCategorie { get; set; }          
           
       public virtual ICollection<Categorie> DomainesActivitesCategorie { get; set; }//
    }
}
