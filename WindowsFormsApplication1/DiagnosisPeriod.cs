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
    public partial class DiagnosisPeriod : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private string date1;
        private string date2;
        public DiagnosisPeriod(SqlConnection sc,string date1,string date2)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.date1 = date1;
            this.date2 = date2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();

            string query = "Select top (10) Treatment.Diagnosis, count(*),Patient.Name from Treatment join Patient on Patient.idPatient = Treatment.idPatient where Treatment.DateOfAppoint >= @Date1 and Treatment.DateOfAppoint <= @Date2 group by Treatment.Diagnosis,Patient.Name order by 2 desc";

            SqlCommand command = new SqlCommand(query, sc);
            command.Parameters.AddWithValue("Date1", Convert.ToDateTime(date1));
            command.Parameters.AddWithValue("Date2", Convert.ToDateTime(date2));
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
