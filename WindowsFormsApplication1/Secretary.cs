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
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Secretary : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Secretary()
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

        private void Secretary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.dataSet1.Staff);
            // TODO: This line of code loads data into the 'dataSet1.Reception' table. You can move, or remove it, as needed.
            this.receptionTableAdapter.Fill(this.dataSet1.Reception);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataSet1.Patient);

        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void receptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Регистрация
        {
            PatientInsert insert = new PatientInsert(cmd.Connection);
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Прием в конкретный день
        {
            if (dateTimePicker1.Text != "")
            {
                string passport = dateTimePicker1.Text;
                this.receptionTableAdapter.FillByData(this.dataSet1.Reception, Convert.ToDateTime(dateTimePicker1.Text));
            }
            else
            {
                MessageBox.Show("Строка даты пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Данные о враче
        {
            if (textBox1.Text != "")
            {
                int id = Convert.ToInt32(textBox1.Text);
                this.staffTableAdapter.FillById(this.dataSet1.Staff, id);
            }
            else
            {
                MessageBox.Show("Строка номера врача пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Удаление завершенных приемов
        {
            this.receptionTableAdapter.DeleteFinished();
            MessageBox.Show("Завершенные приемы удалены.", "Очистка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button5_Click(object sender, EventArgs e)//Архивирование завершенных лечений
        {
            this.receptionTableAdapter.InsertQuery();
            MessageBox.Show("Завершенные лечения архивированы.", "Архивирование", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)//Просмотр архива
        {
            Archive archive = new Archive(cmd.Connection);
            archive.Show();
        }

        private void button7_Click(object sender, EventArgs e)//Update
        {
            this.receptionTableAdapter.Fill(this.dataSet1.Reception);
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
        }

        private void button8_Click(object sender, EventArgs e)//Добавить прием
        {
            if (patientDataGridView.CurrentRow.Selected == true && !patientDataGridView.CurrentRow.IsNewRow)
            {
                ReceptionInsert reception = new ReceptionInsert(cmd.Connection, Convert.ToInt32(patientDataGridView.CurrentRow.Cells[6].Value));
                reception.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужного пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)//Удалить пациента
        {
            if (patientDataGridView.CurrentRow.Selected == true && !patientDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить данного пациента?", "Удаление пациента", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (res)
                {
                    case DialogResult.OK:
                        
                        SqlCommand deleteTreatment = new SqlCommand("DELETE FROM [Treatment] WHERE idTreatment in (SELECT idTreatment FROM [Treatment] WHERE [idPatient] = @Id)", sc);
                        SqlCommand deleteRecep = new SqlCommand("DELETE FROM [Reception] WHERE idReception in (SELECT idReception FROM [Reception] WHERE [idPatient] = @Id)", sc);
                        SqlCommand deletePatient = new SqlCommand("DELETE FROM [Patient] WHERE [idPatient] = @Id", sc);
                        SqlCommand deleteAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification",sc);
                        deletePatient.Parameters.AddWithValue("Id", Convert.ToInt32(patientDataGridView.CurrentRow.Cells[6].Value));
                        deleteAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(patientDataGridView.CurrentRow.Cells[4].Value));
                        deleteTreatment.Parameters.AddWithValue("Id", Convert.ToInt32(patientDataGridView.CurrentRow.Cells[6].Value));
                        deleteRecep.Parameters.AddWithValue("Id", Convert.ToInt32(patientDataGridView.CurrentRow.Cells[6].Value));
                        try
                        {
                            deleteTreatment.ExecuteNonQuery();
                            deleteRecep.ExecuteNonQuery();
                            deletePatient.ExecuteNonQuery();
                            deleteAuth.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужного пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 auth = new Form1();
            Close();
            auth.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int id = Convert.ToInt32(textBox1.Text);
                this.receptionTableAdapter.FillByFinishedReceptionByDoctorsId(this.dataSet1.Reception,id);
            }
            else
            {
                MessageBox.Show("Строка номера врача пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FinishedTreatment finished = new FinishedTreatment(sc);
            finished.Show();
        }

        private void button13_Click(object sender, EventArgs e)//Завершенный прием но не лечение
        {
            this.patientTableAdapter.FillByUnfinishedTreatmentFinishedAppoint(this.dataSet1.Patient);
        }
    }
}

