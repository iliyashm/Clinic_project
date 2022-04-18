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
    public partial class Patient : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Patient()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dataSet1.Patient);

        }

        private void button1_Click(object sender, EventArgs e)//Ввод паспорта
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                this.treatmentTableAdapter.FillByPatientPassport(this.dataSet1.Treatment, passport);
                this.patientTableAdapter.FillByPatientPassport2(this.dataSet1.Patient, passport);
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Изменение данных
        {
            if (patientDataGridView.CurrentRow.Selected == true && !patientDataGridView.CurrentRow.IsNewRow)
            {
                PatientUpdate update = new PatientUpdate(cmd.Connection, Convert.ToInt32(patientDataGridView.CurrentRow.Cells[0].Value));
                update.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали себя в таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Выход
        {
            Form1 auth = new Form1();
            Close();
            auth.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                this.treatmentTableAdapter.FillByPatientPassport(this.dataSet1.Treatment, passport);
                this.patientTableAdapter.FillByPatientPassport2(this.dataSet1.Patient, passport);
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                FinishedReception finised = new FinishedReception(sc, passport);
                finised.Show();
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
