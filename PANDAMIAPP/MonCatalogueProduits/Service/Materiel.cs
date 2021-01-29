using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MonCatalogueProduit.Service;

namespace GestionProduits.Service
{
    [Table("MATERIELS")]
    public class Materiel
    {
        [Key]
        public int MaterielID { get; set; }
        public string  LibelleMateriel { get; set; }
       public virtual ICollection<Demande> DemandeMateriels { get; set; }
        public virtual ICollection<Categorie> MaterielsDomainesActiviter { get; set; }
    }
}
