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
    public partial class Doctor : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Doctor()
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

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Reception' table. You can move, or remove it, as needed.
            //this.receptionTableAdapter.Fill(this.dataSet1.Reception);
            // TODO: This line of code loads data into the 'dataSet1.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.dataSet1.Treatment);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dataSet1.Patient);

        }

        private void button2_Click(object sender, EventArgs e)//Поиск по номеру пациента
        {
            if (textBox2.Text != "")
            {
                int id = Convert.ToInt32(textBox2.Text);
                this.patientTableAdapter.FillByidOfPatientForDoctor(this.dataSet1.Patient, id);
            }
            else
            {
                MessageBox.Show("Строка номера пациента пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Добавить диагноз
        {
            if (patientDataGridView.CurrentRow.Selected == true && !patientDataGridView.CurrentRow.IsNewRow && textBox1.Text != "")
            {
                string passport = textBox1.Text;
                int id = Convert.ToInt32(patientDataGridView.CurrentRow.Cells[0].Value);
                InsertTreatment insert = new InsertTreatment(sc, id, passport);
                insert.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужного пациента или строка паспорта пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Заполнить таблицы по номеру паспорта
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                this.treatmentTableAdapter.FillByDoctorsPassport(this.dataSet1.Treatment, passport);
                this.patientTableAdapter.FillByFillByPatientByDocPassport666(this.dataSet1.Patient, passport);
                this.receptionTableAdapter.FillByReceptionByDocPassport(this.dataSet1.Reception, passport);
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Завершение приема
        {
            if (receptionDataGridView.CurrentRow.Selected == true && !receptionDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();
                SqlCommand insertFinished = new SqlCommand("Update [Reception] SET [isFinished] = @isFinised WHERE idReception = @idReception", sc);

                insertFinished.Parameters.AddWithValue("isFinised", "Завершен");
                insertFinished.Parameters.AddWithValue("idReception", Convert.ToInt32(receptionDataGridView.CurrentRow.Cells[0].Value));

                insertFinished.ExecuteNonQuery();
                MessageBox.Show("Прием отмечен как завершенный, обновите таблицы.", "Завершение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sc.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный прием", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)//Окончание лечения
        {
            if (treatmentDataGridView.CurrentRow.Selected == true && !treatmentDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();
                SqlCommand insertFinishedTreatment = new SqlCommand("UPDATE [Treatment] SET [isFinished] = @isFinised WHERE idTreatment = @idTreatment", sc);

                insertFinishedTreatment.Parameters.AddWithValue("isFinised", "Завершен");
                insertFinishedTreatment.Parameters.AddWithValue("idTreatment", Convert.ToInt32(treatmentDataGridView.CurrentRow.Cells[0].Value));

                insertFinishedTreatment.ExecuteNonQuery();
                MessageBox.Show("Лечение отмеченно как завершенное, обновите таблицы.", "Завершение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sc.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужное лечение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)//Изменить поставленное лечение
        {
            if (treatmentDataGridView.CurrentRow.Selected == true && !treatmentDataGridView.CurrentRow.IsNewRow)
            {
                int id = Convert.ToInt32(treatmentDataGridView.CurrentRow.Cells[0].Value);
                UpdateTreatment update = new UpdateTreatment(sc, id);
                update.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужное лечение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)//Обновить таблицы
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;

                this.patientTableAdapter.FillByFillByPatientByDocPassport666(this.dataSet1.Patient, passport);
                this.receptionTableAdapter.FillByReceptionByDocPassport(this.dataSet1.Reception, passport);
                this.treatmentTableAdapter.FillByDoctorsPassport(this.dataSet1.Treatment, passport);
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 auth = new Form1();
            Close();
            auth.Show();
        }

        private void button9_Click(object sender, EventArgs e)//Популярные жалобы
        {
            if (textBox1.Text != "")
            {
                TopComplaints complaints = new TopComplaints(sc);
                complaints.Show();
            }
            else
            {
                MessageBox.Show("Вы пока не вошли в систему.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)//Диагнозы по сезонам
        {
            if (textBox1.Text != "")
            {
                if(Convert.ToDateTime(dateTimePicker1.Text) < Convert.ToDateTime(dateTimePicker2.Text))
                {
                    DiagnosisPeriod period = new DiagnosisPeriod(sc, dateTimePicker1.Text, dateTimePicker2.Text);
                    period.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный диапазон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы пока не вошли в систему.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                this.patientTableAdapter.FillByFinishedTreatmentsofPatient(this.dataSet1.Patient, passport);
            }
            else
            {
                MessageBox.Show("Вы пока не вошли в систему.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
