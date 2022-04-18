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
    public partial class Insert : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=REVOLT\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Insert(SqlConnection sc)
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

        private void Insert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Autentification' table. You can move, or remove it, as needed.
            //this.autentificationTableAdapter.Fill(this.dataSet1.Autentification);
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.dataSet1.Staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && phoneTextBox.Text != "" && adressTextBox.Text != "" && phoneTextBox.Text != "" && passportTextBox.Text != "" && idAutentificationTextBox.Text != "" && loginTextBox.Text != "" && passwordTextBox.Text != "")
            {


                sc.Open();
                SqlCommand InsertStaff = new SqlCommand("INSERT INTO [Staff] (Name,Phone,Adress,Passport,idAutentification,Role)VALUES(@Name,@Phone,@Adress,@Passport,@idAutentification,@Role)", sc);
                SqlCommand InsertAutentification = new SqlCommand("INSERT INTO [Autentification] (Autentification_id,login,password)VALUES(@Autentification_id,@login,PWDENCRYPT(@password))", sc);
                SqlCommand DelAuth = new SqlCommand("DELETE FROM [Autentification] WHERE Autentification_id = @idAutentification", sc);
                try
                {
                    DelAuth.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                    InsertStaff.Parameters.AddWithValue("Name", nameTextBox.Text);
                    InsertStaff.Parameters.AddWithValue("Phone", phoneTextBox.Text);
                    InsertStaff.Parameters.AddWithValue("Adress", adressTextBox.Text);
                    InsertStaff.Parameters.AddWithValue("Passport", passportTextBox.Text);
                    InsertStaff.Parameters.AddWithValue("idAutentification", Convert.ToInt32(idAutentificationTextBox.Text));
                    InsertStaff.Parameters.AddWithValue("Role", roleTextBox.Text);

                    InsertAutentification.Parameters.AddWithValue("Autentification_id", Convert.ToInt32(idAutentificationTextBox.Text));
                    InsertAutentification.Parameters.AddWithValue("login", loginTextBox.Text);
                    InsertAutentification.Parameters.AddWithValue("password", passwordTextBox.Text);

                   


                    //InsertStaff.ExecuteNonQuery();
                    InsertAutentification.ExecuteNonQuery();
                    InsertStaff.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DelAuth.ExecuteNonQuery();
                    sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idAutentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
