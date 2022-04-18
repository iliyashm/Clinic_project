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
    public partial class UpdateTreatment : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private int id;
        public UpdateTreatment(SqlConnection sc, int id)
        {
            InitializeComponent();
            cmd.Connection = sc;
            this.id = id;
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void UpdateTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.dataSet1.Staff);
            sc.Open();
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.dataSet1.Staff);
            SqlCommand getTreatmentInfo = new SqlCommand("SELECT [Complaints],[Diagnosis] FROM [Treatment] WHERE [idTreatment] = @Id", sc);

            getTreatmentInfo.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;
            //SqlDataReader sqlReader2 = null;
            try
            {
                sqlReader = getTreatmentInfo.ExecuteReader();
                while (sqlReader.Read())
                {
                    complaintsTextBox.Text = Convert.ToString(sqlReader["Complaints"]);
                    diagnosisTextBox.Text = Convert.ToString(sqlReader["Diagnosis"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    //sqlReader2.Close();
                    sqlReader.Close();
                    sc.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand updateTreatment = new SqlCommand("UPDATE [Treatment] SET [Complaints] = @Complaints,[Diagnosis] = @Diagnosis WHERE [idTreatment] = @Id", sc);
            try
            {
                updateTreatment.Parameters.AddWithValue("Complaints", complaintsTextBox.Text);
                updateTreatment.Parameters.AddWithValue("Diagnosis", diagnosisTextBox.Text);
                updateTreatment.Parameters.AddWithValue("Id", id);
              
                updateTreatment.ExecuteNonQuery();

                sc.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sc.Close();
            }
        }
    }
}
