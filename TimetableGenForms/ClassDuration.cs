using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.TtGen
{
    public class ClassDuration
    {
        #region Member


        #endregion Member

        #region Properties
        public TimeSpan Finals { get; set; }
        public TimeSpan HalfFinals { get; set; }
        public TimeSpan SubFinals { get; set; }

        public TimeSpan WaitTime { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for HeatDurations
        /// </summary>
        public ClassDuration()
        {

        }

        public ClassDuration(TimeSpan finals, TimeSpan halfFinals, TimeSpan subFinals, TimeSpan waitTime)
        {
            this.Finals = finals;
            this.HalfFinals = halfFinals;
            this.SubFinals = subFinals;
        }

        public ClassDuration(UInt16 finals, UInt16 halfFinals, UInt16 subFinals, UInt16 waitTime)
        {
            this.Finals =  new TimeSpan(0, finals, 0);
            this.HalfFinals = new TimeSpan(0, halfFinals, 0);
            this.SubFinals = new TimeSpan(0, subFinals, 0);
            this.WaitTime = new TimeSpan(0, waitTime, 0);
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
