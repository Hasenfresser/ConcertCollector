using System;
using System.Windows.Forms;

namespace ConcertCollector
{
    public partial class ConcertCollector : Form
    {
        public static DataManagment.Event ActualEvent;

        public ConcertCollector()
        {
            InitializeComponent();

            ActualEvent = new DataManagment.Event();
        }

        private void tabPage_EventManagement_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Search_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Statistics_Click(object sender, EventArgs e)
        {

        }

        private void label_Event_NameExtra_Click(object sender, EventArgs e)
        {

        }

        private void label_EventManagement_Location_Click(object sender, EventArgs e)
        {

        }

        private void label_EventManagement_DateFrom_Click(object sender, EventArgs e)
        {

        }

        private void label_EventManagement_Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox_EventManagement_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EventManagement_NameExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_EventManagement_From_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_EventManagement_To_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EventManagement_Location_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_EventManagement_Cost_Click(object sender, EventArgs e)
        {

        }

        private void textBox_EventManagement_Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_EventManagement_Bands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_EventManagement_Bands_Click(object sender, EventArgs e)
        {

        }

        private void button_EventManagement_AddBand_Click(object sender, EventArgs e)
        {
            var Window_AddBand = new Layouts.AddBand();

            Window_AddBand.ShowDialog();

        }

        private void ConcertCollector_Load(object sender, EventArgs e)
        {
            
        }
    }
}
