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
    public partial class FinishedReception : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private string passport;
        public FinishedReception(SqlConnection sc,string passport)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.passport = passport;
        }

        private void receptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FinishedReception_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Reception' table. You can move, or remove it, as needed.
            //this.receptionTableAdapter.Fill(this.dataSet1.Reception);
            this.receptionTableAdapter.FillByFinishedReceptionofPatient(this.dataSet1.Reception, passport);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
