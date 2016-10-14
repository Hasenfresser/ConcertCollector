using System;
using System.Windows.Forms;

namespace ConcertCollector
{
    public partial class ConcertCollector : Form
    {
        public static DataManagment.Data ActualData;

        public ConcertCollector()
        {
            InitializeComponent();

            ActualData = new DataManagment.Data();
            ActualData.Events.Add(new DataManagment.Event());            
        }

        private void ConcertCollector_Load(object sender, EventArgs e)
        {

        }

        private void tabPage_EventManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
