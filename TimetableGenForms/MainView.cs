using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rca.TtGen
{
    public partial class MainView : Form
    {
        Controller m_Controller;

        public MainView()
        {
            InitializeComponent();

            m_Controller = new Controller();

            InitDgv();

            cmb_FinCnt.SelectedIndex = 1;
            cmb_GroupSize.SelectedIndex = 1;
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            UInt16 or8drv = 0;
            UInt16 ortdrv = 0;
            UInt16 ore8drv = 0;
            UInt16 durationOr8Fin = 0;
            UInt16 durationOr8HalfFin = 0;
            UInt16 durationOr8SubFin = 0;
            UInt16 durationOrtFin = 0;
            UInt16 durationOrtHalfFin = 0;
            UInt16 durationOrtSubFin = 0;
            UInt16 durationOre8Fin = 0;
            UInt16 durationOre8HalfFin = 0;
            UInt16 durationOre8SubFin = 0;
            UInt16 waitOr8 = 0;
            UInt16 waitOrt = 0;
            UInt16 waitOre8 = 0;
            UInt16 groupSize = 10;
            UInt16 changeTime = 0;
            DateTime startTime = new DateTime(2016,1,1,12,0,0,0);


            if (txt_Or8Driver.Text != "")
            {
                if (!UInt16.TryParse(txt_Or8Driver.Text, out or8drv))
                    MessageBox.Show("Fehlerhafte Eingabe der Starteranzahl für die Klasse OR8");

            }

            if (txt_OrtDriver.Text != "")
            {
                if (!UInt16.TryParse(txt_OrtDriver.Text, out ortdrv))
                    MessageBox.Show("Fehlerhafte Eingabe der Starteranzahl für die Klasse ORT");

            }

            if (txt_Ore8Driver.Text != "")
            {
                if (!UInt16.TryParse(txt_Ore8Driver.Text, out ore8drv))
                    MessageBox.Show("Fehlerhafte Eingabe der Starteranzahl für die Klasse ORE8");

            }

            if (cmb_GroupSize.Text != "")
            {
                if (!UInt16.TryParse(cmb_GroupSize.Text, out groupSize))
                    MessageBox.Show("Fehlerhafte Eingabe der Gruppengröße");

            }

            if (txt_DurationOr8Fin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOr8Fin.Text, out durationOr8Fin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Finale) für die Klasse OR8");

            }

            if (txt_DurationOr8HalfFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOr8HalfFin.Text, out durationOr8HalfFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Halbfinale) für die Klasse OR8");

            }

            if (txt_DurationOr8SubFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOr8SubFin.Text, out durationOr8SubFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Subfinale) für die Klasse OR8");

            }

            if (txt_DurationOrtFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOrtFin.Text, out durationOrtFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Finale) für die Klasse ORT");

            }

            if (txt_DurationOrtHalfFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOrtHalfFin.Text, out durationOrtHalfFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Halbfinale) für die Klasse ORT");

            }

            if (txt_DurationOrtSubFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOrtSubFin.Text, out durationOrtSubFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Subfinale) für die Klasse ORT");

            }

            if (txt_DurationOre8Fin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOre8Fin.Text, out durationOre8Fin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Finale) für die Klasse ORE8");

            }

            if (txt_DurationOre8HalfFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOre8HalfFin.Text, out durationOre8HalfFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Halbfinale) für die Klasse ORE8");

            }

            if (txt_DurationOre8SubFin.Text != "")
            {
                if (!UInt16.TryParse(txt_DurationOre8SubFin.Text, out durationOre8SubFin))
                    MessageBox.Show("Fehlerhafte Eingabe der Laufdauer (Subfinale) für die Klasse ORE8");

            }

            if (txt_WaitOr8.Text != "")
            {
                if (!UInt16.TryParse(txt_WaitOr8.Text, out waitOr8))
                    MessageBox.Show("Fehlerhafte Eingabe der Wartezeit für die Klasse OR8");

            }

            if (txt_WaitOrt.Text != "")
            {
                if (!UInt16.TryParse(txt_WaitOrt.Text, out waitOrt))
                    MessageBox.Show("Fehlerhafte Eingabe der Wartezeit für die Klasse ORT");

            }

            if (txt_WaitOre8.Text != "")
            {
                if (!UInt16.TryParse(txt_WaitOre8.Text, out waitOre8))
                    MessageBox.Show("Fehlerhafte Eingabe der Wartezeit für die Klasse ORE8");

            }

            if (txt_ChangeTime.Text != "")
            {
                if (!UInt16.TryParse(txt_ChangeTime.Text, out changeTime))
                    MessageBox.Show("Fehlerhafte Eingabe der Wechselzeit zwischen den Läufen");

            }

            if (txt_StartTime.Text != "")
            {
                if (!DateTime.TryParse(txt_StartTime.Text, out startTime))
                {
                    MessageBox.Show("Fehlerhafte Eingabe der Startzeit");
                }
            }

            try
            {
                m_Controller.Durations[(int)ClassEnum.Or8] = new ClassDuration(durationOr8Fin, durationOr8HalfFin, durationOr8SubFin, waitOr8);
                m_Controller.Durations[(int)ClassEnum.Ort] = new ClassDuration(durationOrtFin, durationOrtHalfFin, durationOrtSubFin, waitOrt);
                m_Controller.Durations[(int)ClassEnum.Ore8] = new ClassDuration(durationOre8Fin, durationOre8HalfFin, durationOre8SubFin, waitOre8);

                m_Controller.ChangeTime = new TimeSpan(0, changeTime, 0);
                m_Controller.FinalCount = Convert.ToInt32(cmb_FinCnt.Text);
                m_Controller.StartTime = startTime;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Übernahme der Einstellungen");
            }

            m_Controller.AddLastFinal = cbx_AddLastFinal.Checked;

            if (!m_Controller.GenerateFinals(or8drv, ortdrv, ore8drv, groupSize))
                MessageBox.Show("Fehlgeschlagen");
            else
            {
                //Daten ausgeben
                UpdateDgv();

            }
        }

        private void UpdateDgv()
        {

            dgv_Timetable.DataSource = m_Controller.Heats;
        }

        private void InitDgv()
        {
            dgv_Timetable.AutoGenerateColumns = false;
            dgv_Timetable.ColumnCount = 7;

            dgv_Timetable.Columns[0].DataPropertyName = "StartTime";
            dgv_Timetable.Columns[0].Name = "startTime";
            dgv_Timetable.Columns[0].HeaderText = "Startzeit";
            dgv_Timetable.Columns[0].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            dgv_Timetable.Columns[0].Width = 52;

            dgv_Timetable.Columns[1].DataPropertyName = "FinalName";
            dgv_Timetable.Columns[1].Name = "heat";
            dgv_Timetable.Columns[1].HeaderText = "Lauf";
            dgv_Timetable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_Timetable.Columns[2].DataPropertyName = "FinalLetter";
            dgv_Timetable.Columns[2].Name = "suffix";
            dgv_Timetable.Columns[2].HeaderText = "#";
            dgv_Timetable.Columns[2].Width = 21;

            dgv_Timetable.Columns[3].DataPropertyName = "Duration";
            dgv_Timetable.Columns[3].Name = "duration";
            dgv_Timetable.Columns[3].HeaderText = "Laufdauer";
            dgv_Timetable.Columns[3].Width = 60;

            dgv_Timetable.Columns[4].DataPropertyName = "ClassName";
            dgv_Timetable.Columns[4].Name = "heatClass";
            dgv_Timetable.Columns[4].HeaderText = "Klasse";
            dgv_Timetable.Columns[4].Width = 48;

            dgv_Timetable.Columns[5].DataPropertyName = "EndTime";
            dgv_Timetable.Columns[5].Name = "endTime";
            dgv_Timetable.Columns[5].HeaderText = "Endzeit";
            dgv_Timetable.Columns[5].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            dgv_Timetable.Columns[5].Width = 56;

            dgv_Timetable.Columns[6].DataPropertyName = "DriverCount";
            dgv_Timetable.Columns[6].Name = "drivers";
            dgv_Timetable.Columns[6].HeaderText = "Eingeteilt";
            dgv_Timetable.Columns[6].Width = 58;
        }

        private void rb_AdditionaFinals_CheckedChanged(object sender, EventArgs e)
        {
            m_Controller.AdditionalFinals = rb_AdditionalFinals.Checked;
        }
    }
}
