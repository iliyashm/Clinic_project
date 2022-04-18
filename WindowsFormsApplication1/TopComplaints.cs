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
    public partial class TopComplaints : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public TopComplaints(SqlConnection sc)
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treatmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TopComplaints_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.Open();

            string query = "Select top (10) Treatment.Complaints, count(*),Patient.Name from Treatment join Patient on Patient.idPatient = Treatment.idPatient group by Treatment.Complaints,Patient.Name order by 2 desc";

            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            sc.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
