
using GestionProduits.Service;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonCatalogueProduit.Service
{
    public class CatalogueDbContext : DbContext
    {

        public DbSet<Demande> ListeDemandes { set; get; }
        public DbSet<Categorie> ListeCategories { set; get; }
        public DbSet<CategorieDomaine> CategoriesDomaines { set; get; }
        public DbSet<Materiel> ListMateriel { set; get; }
        public DbSet<Reponse> ListReponse { set; get; }
        public DbSet<Satisfaction> ListSatisfaction { set; get; }
        public DbSet<Concertation> ListConcertation { set; get; }
        public DbSet<MotifAnnulation> ListMotifAnnulation{set;get;}
        public DbSet<Utilisateur> ListUtilisateurs { get; set; }
        public DbSet<PreferenceDomaine> ListePreferenceDomaine { get; set; }
        public DbSet<PreferenceJourHoraire> ListePreferenceJourHoraires { get; set; }
        public DbSet<RefJourSemaine> ListRrefJourSemaine { get; set; }     
        public DbSet<PreferenceRayonAction> ListPreferenceRayonAction { get; set; }
        public DbSet<ReferenctielSexe> ListSexe { get; set; }
        public DbSet<MotifDesinscription> ListMotifDesinscription { get; set; }
        public DbSet<Indisponibilite>ListIndisponiblite { get; set; }
        public DbSet<ReferentielRegion> ListRegion { get; set; }
        public DbSet<ReferentielVille> ListVille { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Nom de serveur + Nom de base de donneer + 
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Pandami;Trusted_Connection=True");
        }
    }
}
