using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rca.TtGen
{
    public partial class SplashScreen : Form
    {
        int m_Counter = 0;

        /// <summary>
        /// Blendet den Splashscreen ein
        /// </summary>
        /// <param name="time">Darstellungszeit in Millisekunden</param>
        public SplashScreen(UInt16 time)
        {
            if (time < 100)
            {
                timer1.Stop();
                this.Close();
            }
            else
                m_Counter = time / 100;

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_Counter--;
            if (m_Counter == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
