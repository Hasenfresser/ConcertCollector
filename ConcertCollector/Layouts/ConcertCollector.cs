using System;
using System.Globalization;
using System.Windows.Forms;

namespace ConcertCollector
{
    public partial class ConcertCollector : Form
    {
        public static DataManagment.Data ActualData;
        public static DataManagment.Event ActualEvent;

        DateTime DateFrom = new DateTime();
        DateTime DateTo = new DateTime();

        public ConcertCollector()
        {
            InitializeComponent();

            ActualEvent = new DataManagment.Event();
            ActualData = new DataManagment.Data();

            DateFrom = DateTime.ParseExact(dateTimePicker_EventManagement_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTo = DateTime.ParseExact(dateTimePicker_EventManagement_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
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
            DateFrom = DateTime.ParseExact(dateTimePicker_EventManagement_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (DateFrom.CompareTo(DateTo) > 0)
                dateTimePicker_EventManagement_To.Value = dateTimePicker_EventManagement_From.Value;
        }

        private void dateTimePicker_EventManagement_To_ValueChanged(object sender, EventArgs e)
        {
            DateTo = DateTime.ParseExact(dateTimePicker_EventManagement_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (DateFrom.CompareTo(DateTo) > 0)
                dateTimePicker_EventManagement_From.Value = dateTimePicker_EventManagement_To.Value;            
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

            listBox_EventManagement_Bands.Items.Clear();

            for (int Counter = 0; Counter < ActualEvent.Bands.Count; ++Counter)
                if (ActualEvent.Bands[Counter].NameExtra != "")
                    listBox_EventManagement_Bands.Items.Add(ActualEvent.Bands[Counter].Name + " (" + ActualEvent.Bands[Counter].NameExtra + ')');
                else
                    listBox_EventManagement_Bands.Items.Add(ActualEvent.Bands[Counter].Name);


        }

        private void ConcertCollector_Load(object sender, EventArgs e)
        {
            
        }

        private void button_EventManagement_Save_Click(object sender, EventArgs e)
        {
            ActualEvent.Name = textBox_EventManagement_Name.Text;
            ActualEvent.NameExtra = textBox_EventManagement_NameExtra.Text;
            ActualEvent.DateFrom = DateTime.ParseExact(dateTimePicker_EventManagement_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ActualEvent.DateTo = DateTime.ParseExact(dateTimePicker_EventManagement_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ActualEvent.Location = textBox_EventManagement_Location.Text;

            float Result = new float();

            if(float.TryParse(textBox_EventManagement_Cost.Text, out Result))
                ActualEvent.Cost = Result;
            else
                ActualEvent.Cost = 0;
            
            ActualEvent.Bands.Add(new DataManagment.Band());
        }
    }
}
