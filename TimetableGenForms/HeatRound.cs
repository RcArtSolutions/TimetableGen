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
        public FinalNameEnum RoundName { get; private set; }

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
        public int Looser
        {
            get
            {
                if ((Places - Riser) < 0)
                    return 0;
                else
                    return Places - Riser;
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Konstruiert ein leeres HeatRound-Objekt
        /// </summary>
        public HeatRound()
        {

        }

        /// <summary>
        /// Konstruiert ein neues HeatRound-Objekt
        /// </summary>
        /// <param name="finalName">Round (Finale)</param>
        public HeatRound(FinalNameEnum finalName)
        {
            this.RoundName = finalName;
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
