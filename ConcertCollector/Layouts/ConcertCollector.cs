using System;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConcertCollector
{
    public partial class ConcertCollector : Form
    {
        public static DataManagment.Data ActualData;

        DateTime DateFrom = new DateTime();
        DateTime DateTo = new DateTime();

        bool Error;

        public ConcertCollector()
        {
            InitializeComponent();

            ActualData = new DataManagment.Data();
            ActualData.Events.Add(new DataManagment.Event());

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

            for (int Counter = 0; Counter < ActualData.Events[ActualData.Events.Count - 1].Bands.Count; ++Counter)
                if (ActualData.Events[ActualData.Events.Count - 1].Bands[Counter].NameExtra != "")
                    listBox_EventManagement_Bands.Items.Add(ActualData.Events[ActualData.Events.Count - 1].Bands[Counter].Name + 
                        " (" + ActualData.Events[ActualData.Events.Count - 1].Bands[Counter].NameExtra + ')');
                else
                    listBox_EventManagement_Bands.Items.Add(ActualData.Events[ActualData.Events.Count - 1].Bands[Counter].Name);


        }

        private void ConcertCollector_Load(object sender, EventArgs e)
        {
            
        }

        private void button_EventManagement_Save_Click(object sender, EventArgs e)
        {
            Error = false;

            ActualData.Events[ActualData.Events.Count - 1].Name = textBox_EventManagement_Name.Text.Trim();
            ActualData.Events[ActualData.Events.Count - 1].Location = textBox_EventManagement_Location.Text.Trim();

            if (ActualData.Events[ActualData.Events.Count - 1].Name == "" ||
                ActualData.Events[ActualData.Events.Count - 1].Location == "" ||
                ActualData.Events[ActualData.Events.Count - 1].Bands.Count < 1)
                Error = true;            

            ActualData.Events[ActualData.Events.Count - 1].NameExtra = textBox_EventManagement_NameExtra.Text.Trim();
            ActualData.Events[ActualData.Events.Count - 1].DateFrom = DateTime.ParseExact(dateTimePicker_EventManagement_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ActualData.Events[ActualData.Events.Count - 1].DateTo = DateTime.ParseExact(dateTimePicker_EventManagement_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
            float Result = new float();

            if (float.TryParse(textBox_EventManagement_Cost.Text, out Result))
                ActualData.Events[ActualData.Events.Count - 1].Cost = Result;
            else
                ActualData.Events[ActualData.Events.Count - 1].Cost = 0;

            if (!Error)
            {
                ActualData.Events[ActualData.Events.Count - 1].ID = ActualData.Events.Count - 1;                

                String JsonString = new JavaScriptSerializer().Serialize(ActualData);

                System.IO.StreamWriter DataFile = new System.IO.StreamWriter("Data.ror");
                DataFile.WriteLine(JsonString);

                DataFile.Close();

                ActualData.Events.Add(new DataManagment.Event());

                textBox_EventManagement_Name.Text = "";
                textBox_EventManagement_NameExtra.Text = "";
                textBox_EventManagement_Location.Text = "";
                textBox_EventManagement_Cost.Text = "";

                listBox_EventManagement_Bands.Items.Clear();
            }
            else
            {
                MessageBox.Show("\"Name\", \"Ort\" und \"Bands\" darf nicht leer sein.", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }
    }
}
