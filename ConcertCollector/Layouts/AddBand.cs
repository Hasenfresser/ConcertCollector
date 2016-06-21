using System;
using System.Windows.Forms;

namespace ConcertCollector.Layouts
{
    public partial class AddBand : Form
    {
        public AddBand()
        {
            InitializeComponent();

            textBox_AddBand_Name.Text = "";
            textBox_AddBand_NameExtra.Text = "";
            textBox_AddBand_Info.Text = "";
        }



        private void label_AddBand_Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox_AddBand_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AddBand_NameExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AddBand_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBand_Load(object sender, EventArgs e)
        {

        }

        private void label_AddBand_Info_Click(object sender, EventArgs e)
        {

        }

        private void label_AddBand_NameExtra_Click(object sender, EventArgs e)
        {

        }

        private void button_AddBand_Add_Click(object sender, EventArgs e)
        {
            DataManagment.Band ActualBand = new DataManagment.Band();

            ActualBand.Name = textBox_AddBand_Name.Text;
            ActualBand.NameExtra = textBox_AddBand_NameExtra.Text;
            ActualBand.Info = textBox_AddBand_Info.Text;

            MessageBox.Show("Test 1", "Bla", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            MessageBox.Show("Test 2", "Bla", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            AddBand.ActiveForm.Hide();

            this.Dispose();
            this.Close();
        }
    }
}
