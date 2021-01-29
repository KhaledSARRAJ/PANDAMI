using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProduits.Service
{
    [Table ("REFERENTIELREGION")]
    public class ReferentielRegion
    {

        [Key]
        public int RegionID { get; set; }
        public string LibelleRegion { get; set; }
        [StringLength(100)]
        public virtual ICollection<ReferentielVille> ReferentielRegionRefrentielVille { get; set; }

    }
}
