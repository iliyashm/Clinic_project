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
    public partial class Archive : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Archive(SqlConnection sc)
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void treatment_ArchiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatment_ArchiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Treatment_Archive' table. You can move, or remove it, as needed.
            this.treatment_ArchiveTableAdapter.Fill(this.dataSet1.Treatment_Archive);

        }

        private void button1_Click(object sender, EventArgs e)//Поиск по врачу
        {
            if (textBox1.Text != "")
            {
                int id = Convert.ToInt32(textBox1.Text);
                this.treatment_ArchiveTableAdapter.FillByidDoctors(this.dataSet1.Treatment_Archive, id);
            }
            else
            {
                MessageBox.Show("Строка номера врача пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Поиск по пациенту
        {
            if (textBox2.Text != "")
            {
                int id = Convert.ToInt32(textBox2.Text);
                this.treatment_ArchiveTableAdapter.FillByidPatient(this.dataSet1.Treatment_Archive, id);
            }
            else
            {
                MessageBox.Show("Строка номера пациента пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Обновить
        {
            this.treatment_ArchiveTableAdapter.Fill(this.dataSet1.Treatment_Archive);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
