using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entrainement181119.Modele
{
    class Prohets
    {
        class Projet
        {
            public static ArrayList CollClassProjet = new ArrayList();

            private string nom;
            private DateTime debut;
            private DateTime fin;
            private int prixfactureMO;
            private ArrayList lesMissions;



            public Projet(string nom, DateTime debut, DateTime fin, int prixfactureMO)
            {
                this.Nom = nom;
                this.Debut = debut;
                this.Fin = fin;
                this.PrixfactureMO = prixfactureMO;
                
                Projet.CollClassProjet.Add(this);
                LesMissions = new ArrayList();
            }

            public string Nom { get => nom; set => nom = value; }
            public DateTime Debut { get => debut; set => debut = value; }
            public DateTime Fin { get => fin; set => fin = value; }
            public int PrixfactureMO { get => prixfactureMO; set => prixfactureMO = value; }
            public ArrayList LesMissions { get => lesMissions; set => lesMissions = value; }

            private float cumulCoutMO()
            {
                //retourne le coût cumulé des heures de main d’œuvre effectuées pour l’ensemble
                // des missions du projet 

                //creation d'une variable acumulation
                //On parcours toute les mission du projet
                //Pour chaque mission, on utilise la fonction pour connaitre la thune (On va passer par l'exécutant

                float resultat = 0;
                

                foreach (Mission m in this.LesMissions)
                {
                    resultat += m.nbHeureEffectuees() * m.executant.tauxHoraire;
                }
                return resultat;
            }
        }

    }
}
