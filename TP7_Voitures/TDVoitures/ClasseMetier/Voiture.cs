using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDVoitures.Outils;

namespace TDVoitures.ClasseMetier
{
    class Voiture
    {
        public static int anneeEnCours = 2022;

        private int id;
        private double prixAchat;
        private Couleur couleur;
        private int anneeMiseEnService;
        private int capaciteReservoir;
        private double nbLitresContenus;
        private double nbKilometresCompteur;
        private Marque marque;

        public int Id { get => id; }
        public double PrixAchat { get => prixAchat; }
        public Couleur Couleur { get => couleur; }
        public int AnneeMiseEnService { get => anneeMiseEnService; }
        public int CapaciteReservoir { get => capaciteReservoir;  }
        public double NbLitresContenus { get => nbLitresContenus; set => nbLitresContenus = value; }
        public double NbKilometresCompteur { get => nbKilometresCompteur; set => nbKilometresCompteur = value; }
        public Marque Marque { get => marque; }

        /// <summary>
        /// Pour les voitures d'occasion
        /// </summary>
        /// <param name="prixAchat"></param>
        /// <param name="couleur"></param>
        /// <param name="anneeMiseEnService"></param>
        /// <param name="capaciteReservoir"></param>
        /// <param name="nbLitresContenus"></param>
        /// <param name="nbKilometresCompteur"></param>
        /// <param name="marque"></param>
        public Voiture(int id,double prixAchat,Couleur couleur,int anneeMiseEnService,int capaciteReservoir,int nbLitresContenus, double nbKilometresCompteur,Marque marque)
        {
            this.id = id;
            this.prixAchat = prixAchat;
            this.couleur = couleur;
            this.anneeMiseEnService = anneeMiseEnService;
            this.capaciteReservoir = capaciteReservoir;
            this.nbLitresContenus = nbLitresContenus;
            this.nbKilometresCompteur = nbKilometresCompteur;
            this.marque = marque;

            if (this.nbLitresContenus > capaciteReservoir)
            {
                throw new Exception("Le nombre d'essence est superieur a la capacité réservoir");
            } 
            if (this.nbLitresContenus < 0)
            {
                throw new Exception("L'essence ne peut avoir une valeur négative");
            }
            if (anneeMiseEnService < 0)
            {
                throw new Exception("Les voitures n'existais pas avant jésus christ");
            }
            if(anneeMiseEnService > anneeEnCours)
            {
                throw new Exception("Cette année n'existe pas encore");
            }
            if(marque == null)
            {
                throw new Exception("La marque n'existe pas");
            }
            if(prixAchat < 0)
            {
                throw new Exception("Le prix ne peut pas etre négative");
            }
        }

        /// <summary>
        /// Pour les voitures neuves
        /// </summary>
        /// <param name="prixAchat"></param>
        /// <param name="couleur"></param>
        /// <param name="anneeMiseEnService"></param>
        /// <param name="capaciteReservoir"></param>
        /// <param name="nbLitresContenus"></param>
        /// <param name="nbKilometresCompteur"></param>
        /// <param name="marque"></param>
        public Voiture(int id, double prixAchat, Couleur couleur, int anneeMiseEnService, int capaciteReservoir, Marque marque) :
            this(id,prixAchat,couleur,anneeMiseEnService,capaciteReservoir,0,0,marque) { }

        /// <summary>
        /// Pour les voitures dites alternative
        /// </summary>
        /// <param name="prixAchat"></param>
        /// <param name="couleur"></param>
        /// <param name="anneeMiseEnService"></param>
        /// <param name="capaciteReservoir"></param>
        /// <param name="nbLitresContenus"></param>
        /// <param name="nbKilometresCompteur"></param>
        /// <param name="marque"></param>
        public Voiture(int id,double prixAchat, Couleur couleur, int capaciteReservoir, int nbLitresContenus, double nbKilometresCompteur, Marque marque):
            this(id, prixAchat, couleur, anneeEnCours, capaciteReservoir,0,0,marque) { }

        public void ToString ()
        {
            Console.WriteLine("Prix = " +prixAchat);
            Console.WriteLine("Couleur = " + couleur.ToString() );
            Console.WriteLine("Annee mise en service = " + anneeMiseEnService );
            Console.WriteLine("Nombre de kilometres au compteur = " + nbKilometresCompteur );
            Console.WriteLine("Marque = " + marque.nom);

        }

        public bool Rouler (int kilometreAEffectuer)
        {
            double LitreConsommer = 8 * kilometreAEffectuer / 100;
            if (nbLitresContenus >= LitreConsommer)
            {
                nbLitresContenus -= LitreConsommer;
                NbKilometresCompteur += kilometreAEffectuer;
                if(nbLitresContenus < 10)
                {
                    Console.WriteLine("Vous êtes sur la réserve, pensez à faire de l'essence");
                }
                return true;
            } 
            else
            {
                Console.WriteLine("Impossible d'effectuer le trajet par manque d'essence");
                return false;
            }
        }

        public void Remplir () 
        {
            nbLitresContenus = capaciteReservoir;

            Console.WriteLine("Vous avez {0} essence disponible", nbLitresContenus);
        }

        public void Remplir (double essenceARajouter)
        {
            double capaciteDisponible = capaciteReservoir - NbLitresContenus;
            if (capaciteDisponible > essenceARajouter)
            {
                nbLitresContenus += essenceARajouter;
            } else
            {
                nbLitresContenus = capaciteReservoir;
            }

            Console.WriteLine("Vous avez {0} essence disponible", nbLitresContenus);
        }
    }
}
