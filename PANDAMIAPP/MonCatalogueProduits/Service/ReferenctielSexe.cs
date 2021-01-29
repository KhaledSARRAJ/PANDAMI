using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table("REFERENTIELSEXE")]
    public class ReferenctielSexe
    {
        [Key]
        public  int SexeID { get; set; }
        public string LibelleSexe { get; set; }
        [StringLength(10)]
        public virtual ICollection<Utilisateur> SexeUtilisateur { get; set; }

    }
}
