using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.TtGen
{
    [DebuggerDisplay("{FinalName} {FinalLetter} - {ClassName} Fahrer: {DriverCount}")]
    public class Heat
    {
        #region Member

        private FinalNameEnum m_Final;
        private FinalCharEnum m_Letter;
        private ClassEnum m_HeatClass;
        #endregion Member

        #region Properties
        public string FinalName { get; private set; }

        public FinalNameEnum Final
        {
            get
            {
                return m_Final;
            }
            set
            {
                m_Final = value;

                var memInfo = typeof(FinalNameEnum).GetMember(m_Final.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                FinalName = ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        public string FinalLetter { get; private set; }

        public FinalCharEnum Letter
        {
            get
            {
                return m_Letter;
            }
            set
            {
                m_Letter = value;

                var memInfo = typeof(FinalCharEnum).GetMember(m_Letter.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                FinalLetter = ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        public int DriverCount { get; set; }

        /// <summary>
        /// In diesem Finale aufsteigende Fahrer
        /// </summary>
        public int RisingDrivers { get; set; }

        /// <summary>
        /// In dieses Finale einsteigende Fahrer
        /// </summary>
        public int UpwardDrivers { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime
        {
            get
            {
                return StartTime + Duration;            
            }
        }

        public TimeSpan Duration { get; set; }

        public string ClassName { get; private set; }

        public ClassEnum HeatClass
        {
            get
            {
                return m_HeatClass;
            }
            set
            {
                m_HeatClass = value;

                var memInfo = typeof(ClassEnum).GetMember(m_HeatClass.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                ClassName = ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        public int RemainingDrivers
        {
            get
            {
                return DriverCount + UpwardDrivers - RisingDrivers;
            }
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Heat
        /// </summary>
        public Heat()
        {

        }

        public Heat(FinalNameEnum finName, FinalCharEnum finChar, int driverCnt, ClassEnum heatClass)
        {
            var memInfo = typeof(FinalNameEnum).GetMember(finName.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            this.FinalName = ((DescriptionAttribute)attributes[0]).Description;
            this.Final = finName;
            this.Letter = finChar;
            this.DriverCount = driverCnt;
            this.HeatClass = heatClass;
        }

        public Heat(FinalNameEnum name, FinalCharEnum finChar, int driverCnt, ClassEnum heatClass, TimeSpan duration)
        {
            var memInfo = typeof(FinalNameEnum).GetMember(name.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            this.FinalName = ((DescriptionAttribute)attributes[0]).Description;
            this.Final = name;
            this.Letter = finChar;
            this.DriverCount = driverCnt;
            this.HeatClass = heatClass;

            this.Duration = duration;
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
