using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FinishedTreatment : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public FinishedTreatment(SqlConnection sc)
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void treatmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FinishedTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
            this.treatmentTableAdapter.FillByFinishedTreatmentOfPatient(this.dataSet1.Treatment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
