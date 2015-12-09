using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rca.TtGen
{
    /// <summary>
    /// Sammelobjekt für Round-Daten
    /// </summary>
    public class HeatRound
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Round (Finale)
        /// </summary>
        public FinalNameEnum FinalName { get; private set; }

        /// <summary>
        /// Tatsächliche Starter
        /// Direkt Qualifizierte + aufsteiger aus dem Unterfinale
        /// </summary>
        public int Places { get; set; }

        /// <summary>
        /// Direkt Qualifizierte Fahrer
        /// </summary>
        public int Qualifier { get; set; }

        /// <summary>
        /// Aufsteiger
        /// </summary>
        public int Riser { get; set; }

        /// <summary>
        /// Nicht Aufsteiger
        /// </summary>
        public int Looser { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for HeatRound
        /// </summary>
        public HeatRound()
        {

        }

        #endregion Constructor

        #region Services


        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
