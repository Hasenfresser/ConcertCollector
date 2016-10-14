using System;
using System.Windows.Forms;

namespace ConcertCollector.Layouts
{
    public partial class AddBand : Form
    {
        bool Error;

        public AddBand()
        {
            InitializeComponent();
        }

        private void AddBand_Load(object sender, EventArgs e)
        {

        }

        private void button_AddBand_Add_Click(object sender, EventArgs e)
        {
            DataManagment.Band ActualBand = new DataManagment.Band();

            Error = false;

            textBox_AddBand_Name.Text = textBox_AddBand_Name.Text.Trim();

            if (textBox_AddBand_Name.Text != "")
                ActualBand.Name = textBox_AddBand_Name.Text;
            else
                Error = true;

            ActualBand.NameExtra = textBox_AddBand_NameExtra.Text;
            ActualBand.Info = textBox_AddBand_Info.Text;

            if(!Error)
            {
                ConcertCollector.ActualData.Events[ConcertCollector.ActualData.Events.Count - 1].Bands.Add(ActualBand);

                this.Dispose();
                this.Close();
            }                
            else
            {
                MessageBox.Show("\"Name\" darf nicht leer sein.", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
