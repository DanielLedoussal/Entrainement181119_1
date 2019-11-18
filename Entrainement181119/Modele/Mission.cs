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
        private Dictionary<string, int> _releveHoraire = new Dictionary<string, int>();
        static ArrayList CollClasseMission = new ArrayList();

        #endregion
        #region Constructeur


        public Mission(string nom, string description, int nbHeurePrevus, Dictionary<string, int> releveHoraire)
        {
            Nom = nom;
            Description = description;
            NbHeurePrevus = nbHeurePrevus;
            ReleveHoraire = releveHoraire;
            Mission.CollClasseMission.Add(this);


        }
        #endregion
        #region Getter setter

       

        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public int NbHeurePrevus { get => _nbHeurePrevus; set => _nbHeurePrevus = value; }
        public Dictionary<string, int> ReleveHoraire { get => _releveHoraire; set => _releveHoraire = value; }
        #endregion

        #region Methode

        public Dictionary<string, int> getRevelveHoraire()
        {
            
        }

        #endregion
    }
}
