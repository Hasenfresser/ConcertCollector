using System;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConcertCollector.Layouts
{
    public partial class EventPage : Form
    {
        DateTime DateFrom = new DateTime();
        DateTime DateTo = new DateTime();

        bool Error;

        public EventPage()
        {
            InitializeComponent();

            DateFrom = DateTime.ParseExact(dateTimePicker_EventPage_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTo = DateTime.ParseExact(dateTimePicker_EventPage_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void EventPage_Load(object sender, EventArgs e)
        {

        }  

        private void dateTimePicker_EventPage_From_ValueChanged(object sender, EventArgs e)
        {
            DateFrom = DateTime.ParseExact(dateTimePicker_EventPage_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (DateFrom.CompareTo(DateTo) > 0)
                dateTimePicker_EventPage_To.Value = dateTimePicker_EventPage_From.Value;
        }

        private void dateTimePicker_EventPage_To_ValueChanged(object sender, EventArgs e)
        {
            DateTo = DateTime.ParseExact(dateTimePicker_EventPage_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (DateFrom.CompareTo(DateTo) > 0)
                dateTimePicker_EventPage_From.Value = dateTimePicker_EventPage_To.Value;
        }

        private void button_EventPage_AddBand_Click(object sender, EventArgs e)
        {
            var Window_AddBand = new Layouts.AddBand();

            Window_AddBand.ShowDialog();

            listBox_EventPage_Bands.Items.Clear();

            for (int Counter = 0; Counter < ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands.Count; ++Counter)
                if (ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands[Counter].NameExtra != "")
                    listBox_EventPage_Bands.Items.Add(ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands[Counter].Name +
                        " (" + ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands[Counter].NameExtra + ')');
                else
                    listBox_EventPage_Bands.Items.Add(ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands[Counter].Name);
        }

        private void button_EventPage_DeleteBand_Click(object sender, EventArgs e)
        {

        }

        private void button_EventPage_Save_Click(object sender, EventArgs e)
        {
            Error = false;

            ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Name = textBox_EventPage_Name.Text.Trim();
            ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Location = textBox_EventPage_Location.Text.Trim();

            if (ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Name == "" ||
                ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Location == "" ||
                ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands.Count < 1)
                Error = true;

            ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].NameExtra = textBox_EventPage_NameExtra.Text.Trim();
            ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].DateFrom = DateTime.ParseExact(dateTimePicker_EventPage_From.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].DateTo = DateTime.ParseExact(dateTimePicker_EventPage_To.Value.ToString("dd.MM.yyyy"), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            float Result = new float();

            if (!Error)
            {
                ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].ID = ConcertCollector.ActualData.Events.Count - 1;

                String JsonString = new JavaScriptSerializer().Serialize(ConcertCollector.ActualData);

                System.IO.StreamWriter DataFile = new System.IO.StreamWriter("Data.ror");
                DataFile.WriteLine(JsonString);

                DataFile.Close();

                ConcertCollector.ActualData.Events.Add(new DataManagment.Event());

                textBox_EventPage_Name.Text = "";
                textBox_EventPage_NameExtra.Text = "";
                textBox_EventPage_Location.Text = "";

                listBox_EventPage_Bands.Items.Clear();
            }
            else
            {
                MessageBox.Show("\"Name\", \"Ort\" und \"Bands\" darf nicht leer sein.", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
