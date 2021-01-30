using System;
using GestionProduits.Service;
using MonCatalogueProduit.Service;

namespace TestBaseDeDonner
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CatalogueDbContext())//using son but est de creer l'objet dbContext mais quant on arrive à la fin de crochet il le ferme 
            {//var : variable dynamique
             //Creation de la base de données           
             
                db.Database.EnsureDeleted(); // supprime moi tout 
                db.Database.EnsureCreated(); // creer moi tout au exécution (attention juste pour la premiere exécution) aprés il faut les mettres en commentaire


                //Ajouter quelques categorie 
                db.CategoriesDomaines.Add(new CategorieDomaine { libelleCategorie ="Medical"});
                db.CategoriesDomaines.Add(new CategorieDomaine { libelleCategorie = "Agricole" });
                db.CategoriesDomaines.Add(new CategorieDomaine { libelleCategorie = "Construction" });
                //Ajouter quelques Materiels 
                db.ListMateriel.Add(new Materiel { LibelleMateriel = "Voiture" });
                db.ListMateriel.Add(new Materiel { LibelleMateriel = "Marteau" });
                db.ListMateriel.Add(new Materiel { LibelleMateriel = "Ponsseuce" });
                //Ajouter quelques Domaine d'activiter
                db.ListeCategories.Add(
                    new Categorie { LibelleDomaine = "Medical", CategorieDomaineID=1, MaterielID = 3}
                    );
                db.ListeCategories.Add(
                    new Categorie { LibelleDomaine = "Agricole", CategorieDomaineID = 1, MaterielID = 1 }
                    );
                db.ListeCategories.Add(
                  new Categorie { LibelleDomaine = "Construction", CategorieDomaineID = 1, MaterielID = 2 }
                  );
                db.ListeCategories.Add(
    new Categorie { LibelleDomaine = "Medical", CategorieDomaineID = 1, MaterielID = 3 }
    );
                db.ListeCategories.Add(
                    new Categorie { LibelleDomaine = "Agricole", CategorieDomaineID = 1, MaterielID = 1 }
                    );
                db.ListeCategories.Add(
                  new Categorie { LibelleDomaine = "Construction", CategorieDomaineID = 1, MaterielID = 2 }
                  ); db.ListeCategories.Add(
     new Categorie { LibelleDomaine = "Medical", CategorieDomaineID = 1, MaterielID = 3 }
     );
                db.ListeCategories.Add(
                    new Categorie { LibelleDomaine = "Agricole", CategorieDomaineID = 1, MaterielID = 1 }
                    );
                db.ListeCategories.Add(
                  new Categorie { LibelleDomaine = "Construction", CategorieDomaineID = 1, MaterielID = 2 }
                  );
                //Ajouter quelques Demande  
                //En deuxiéme lancement garder que les produits pour ajouter
                db.ListeDemandes.Add(new Demande {
                    CategoriesID=1,
                    Description="Faire des courses",                   
                   IdentifiantMateriel = 3,
                    DateEnregistrementDemande = "12/12/2020",
                    DatedeRealisation = new DateTime(2021, 2, 19),
                    IdentifiantMAnnulation = 1,
                    Ville="Caen",
                    Horaire= "aa",
                   IdentifiantUtilisateur =1
                });
                db.ListeDemandes.Add(new Demande
                {
                    CategoriesID = 3,
                    Description = "Aide médical",
                    IdentifiantMateriel = 2,
                    DateEnregistrementDemande = "12/12/2020",
                    DatedeRealisation = new DateTime(2021, 2, 19),
                    IdentifiantMAnnulation = 2,
                    Ville = "Caen",
                    Horaire = "aa",
                    IdentifiantUtilisateur = 2
                });
                db.ListeDemandes.Add(new Demande
                {
                    CategoriesID = 2,
                    Description = "Faire des courses",
                    IdentifiantMateriel = 3,
                    IdentifiantMAnnulation = 1,
                    DateEnregistrementDemande= "12/12/2020",
                    DatedeRealisation = new DateTime(2021, 2, 19),
                    Ville = "Caen",
                    Horaire = "aa",
                    IdentifiantUtilisateur = 1
                });

                //Ajouter quelques Reponses
                db.ListReponse.Add(new Reponse {  DateReponse = DateTime.Now,
                    DateRenonciation = DateTime.Now,
                    DatePriseCompte = DateTime.Now,
                    DemandeID=1,
                    IdentifiantUtilisateur=1
                });
                //Ajouter quelques Satisfactions
                db.ListSatisfaction.Add(new Satisfaction{
                    DateEvaluation = DateTime.Now,
                    NoteConformite = 1,
                    NoteRelation = 5,
                    NoteContact = 7,
                    Message = "Je ne suis pas satisfaite",
                    DemandeID=1,
                    IdentifiantUtilisateur=1
                });
                db.ListConcertation.Add(new Concertation { 
                    DateConcertation = DateTime.Now,
                    HoraireProposer = "17:50",
                    DateProposer = DateTime.Now,
                    ComplementAdresse ="je serai disponible l'aprés midi",
                    DateAcceptation= DateTime.Now,
                    DateRejetDefinitif = DateTime.Now  ,
                    identifiantDemandeID=1,
                    IdentifiantUtilisateur=1
                });
                //Ajouter un motif d'annulation
                db.ListMotifAnnulation.Add(new MotifAnnulation {
                   LibelleMotifAnnul = "Absence"
                });
                //Creer un utilisateur
                db.ListUtilisateurs.Add(new Utilisateur
                {
                    Nom = "Khaled",
                    Prenom = "SARRAJ",
                    DateDeNaissance =DateTime.Now,
                    NomUtilisateur = "KOUKI",
                    AdresseMail = "Khaledinat@gmail.com",
                    DateInscription =  "aaa",
                    NumTel = "0605810246",
                    NumeroRue="22",
                    NomDeRue  ="allee du pere jamet",                  
                    MotDePasse = "ORANEMIKhALED",
                    confirmMotPasse= "ORANEMIKhALED",
                    DateDeDesinscription = "aaa",
                    Ville="Paris",
                    Region="Ile de france",
                    codePostal="22",
                    sexe="Homme",
                    identifiantSexeUser =1,
                    identifiantMotifDesinscription=1,
                    IdentifiantReferentielVille=1
                });
                //Creer un domaine de préférence
                db.ListePreferenceDomaine.Add(new PreferenceDomaine
                {
                    dateDebutPref = DateTime.Now,
                    dateFinPref = DateTime.Now,
                    IdentifiantUtilisateur =1,
                    IdentifiantDomaineActiviter=1

                }); ;
                //Creer une preference jour/horraire
                db.ListePreferenceJourHoraires.Add(
                new PreferenceJourHoraire
                {
                    heureDebut = "17H",
                    heurefin = "20H",
                    DateDebutValidite = DateTime.Now,
                    DateDeFinValidite = DateTime.Now,
                    IdentifiantUtilisateur = 1,
                    IdentifiantJourSemaine=1
                }) ;
                //Creer une ref jour semaine
                db.ListRrefJourSemaine.Add(new RefJourSemaine{
                   LibelleJourSemaine = "lundi"
                
                });
                //Ajouter une liste de preference de rayon d'action
                db.ListPreferenceRayonAction.Add(new PreferenceRayonAction { 
                   ValeurRayon = 50,
                   DateDebutChRay = DateTime.Now,
                   DateFinChRay = DateTime.Now,
                    IdentifiantUtilisateur=1
                });
                //Creer une liste de reference sexe (static)
                db.ListSexe.Add(new ReferenctielSexe{LibelleSexe = " M "});
                db.ListSexe.Add(new ReferenctielSexe { LibelleSexe = " F " });
                db.ListSexe.Add(new ReferenctielSexe { LibelleSexe = " N "});
                //Ajouter un motif de désinscription
                db.ListMotifDesinscription.Add(new MotifDesinscription { 
                   LibelleMotifDesinscr = "je veux m'isoler et plus être en contact avec les êtres humains SALUTTT!!"               
                });
                //Ajouter une indisponibilitée
                db.ListIndisponiblite.Add(new Indisponibilite {                 
                   dateDebutIndispo = DateTime.Now,
                   dateFinIndispo = DateTime.Now,
                   CommentaireIndispo = "Je serai hospitalisé bientot :( désolé",
                   IdentifiantUtilisateur=1
                });
                //Ajouter quelques régions
                db.ListRegion.Add(new ReferentielRegion {LibelleRegion= "Calvados"});
                db.ListRegion.Add(new ReferentielRegion {LibelleRegion = "Ile de France"});
                db.ListRegion.Add(new ReferentielRegion{LibelleRegion = "Bretagne"});

                db.ListVille.Add(new ReferentielVille { LibelleVille = "Caen", CodePostal = 14000, IdentifiantRegion =1});
                db.ListVille.Add(new ReferentielVille{ LibelleVille = "Rennes", CodePostal = 35000, IdentifiantRegion =1});
                db.ShoppingCartItems.Add(new ShoppingCartItem
                {
                    Amount = 0,
                }) ;
                db.Orders.Add(new Order { NomUtilisateur="Hamza", PhoneNumber="1425658"});
                db.OrderDetails.Add(new OrderDetail {IdentifiantOrder=1 ,Amount =0, DemandeID =1});

                db.SaveChanges();//Sauvgarder ce qu'on a creer quant même !!
            }
        }
    }
}