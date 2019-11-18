using Entrainement181119.Modele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entrainement181119
{
    class Mission
    {

        #region Atribut

        private string _nom;
        private string _description;
        private int _nbHeurePrevus;
        private Dictionary<DateTime, int> _releveHoraire;
        static ArrayList CollClasseMission = new ArrayList();
        private Intervenant _executant;

        #endregion
        #region Constructeur


        public Mission(string nom, string description, int nbHeurePrevus, Intervenant executant)
        {
            Nom = nom;
            Description = description;
            NbHeurePrevus = nbHeurePrevus;
            ReleveHoraire = new Dictionary<DateTime, int>();
            Mission.CollClasseMission.Add(this);
            this._executant = executant;


        }
        #endregion
        #region Getter setter

       

        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public int NbHeurePrevus { get => _nbHeurePrevus; set => _nbHeurePrevus = value; }
        public Dictionary<DateTime, int> ReleveHoraire { get => _releveHoraire; set => _releveHoraire = value; }
        #endregion

        #region Methode

        public void AjoutReleve(DateTime jours, int nbHeure)
        {
            this.ReleveHoraire.Add(jours, nbHeure);
        }
        
        public int nbHeureEffectuees()
        {
            int resultat = 0;

            foreach(KeyValuePair<DateTime,int> pair in this.ReleveHoraire){
                resultat += pair.Value;
            }

            return resultat;
        }
        #endregion
    }
}
