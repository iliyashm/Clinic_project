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
    public partial class ТоpDoctors : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public ТоpDoctors(SqlConnection sc)
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();

            string query = "Select top(10) Staff.Name,count(*) from Staff join Treatment on Staff.idStaff = Treatment.idStaff where Treatment.isFinished = 'Завершен' group by Staff.Name";

            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                //data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            sc.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
