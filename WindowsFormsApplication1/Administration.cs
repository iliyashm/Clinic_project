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
    public partial class Administration : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = null;
        public Administration()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)//Select
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)//Insert
        {
            Insert insert = new Insert(cmd.Connection);
            insert.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//Delete
        {
            if (staffDataGridView.CurrentRow.Selected == true && !staffDataGridView.CurrentRow.IsNewRow)
            {
                sc.Open();
                DialogResult res = MessageBox.Show("Вы действительно хотите уволить данного сотрудника?", "Увольнение сотрудника", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (res)
                {
                    case DialogResult.OK:
                        
                        SqlCommand deleteTreatment = new SqlCommand("DELETE FROM [Treatment] WHERE idTreatment in (SELECT idTreatment FROM [Treatment] WHERE [idStaff] = @Id)", sc);
                        SqlCommand deleteRecep = new SqlCommand("DELETE FROM [Reception] WHERE idReception in (SELECT idReception FROM [Reception] WHERE [idStaff] = @Id)", sc);
                        SqlCommand deleteStaff = new SqlCommand("DELETE FROM [Staff] WHERE [idStaff] = @Id", sc);
                        SqlCommand deleteAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification",sc);
                        deleteStaff.Parameters.AddWithValue("Id", Convert.ToInt32(staffDataGridView.CurrentRow.Cells[6].Value));
                        deleteAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(staffDataGridView.CurrentRow.Cells[4].Value));
                        deleteTreatment.Parameters.AddWithValue("Id", Convert.ToInt32(staffDataGridView.CurrentRow.Cells[6].Value));
                        deleteRecep.Parameters.AddWithValue("Id", Convert.ToInt32(staffDataGridView.CurrentRow.Cells[6].Value));
                        try
                        {
                            deleteTreatment.ExecuteNonQuery();
                            deleteRecep.ExecuteNonQuery();
                            deleteStaff.ExecuteNonQuery();
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
                MessageBox.Show("Вы не выбрали нужного сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//Update
        {
            if (staffDataGridView.CurrentRow.Selected == true && !staffDataGridView.CurrentRow.IsNewRow )
            {
                Update update = new Update(cmd.Connection, Convert.ToInt32(staffDataGridView.CurrentRow.Cells[6].Value));
                update.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужного сотрудника","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //staffDataGridView.ClearSelection();
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
        }

        private void staffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string passport = textBox1.Text;
                this.staffTableAdapter.FillBy(this.dataSet1.Staff, passport);
            }
            else
            {
                MessageBox.Show("Строка номера паспорта пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 auth = new Form1();
            Close();
            auth.Show();
        }

        private void button4_Click(object sender, EventArgs e)//Топ врачей
        {
            ТоpDoctors top = new ТоpDoctors(sc);
            top.Show();
        }
    }
}
