using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBillingSystem
{
    public partial class CLP : Form
    {
        Login login;
        public CLP(Login login)
        {
            InitializeComponent();
            this.login = login;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
            connection.Open();
            string sql = "select * from C_List where Username= '" + login.textBox_LP_Username.Text + "' and Password = '" + login.textBox_LP_Password.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                textBox_CLP_Id.Text = reader["id"].ToString();
                textBox_CLP_Name.Text = reader["Name"].ToString();
                textBox_CLP_Username.Text = reader["Username"].ToString();
                dateTimePicker_CLP_DoB.Text = reader["DateOfBirth"].ToString();
                textBox_CLP_Address.Text = reader["Address"].ToString();
                textBox_CLP_Email.Text = reader["Email"].ToString();
                textBox_CLP_Password.Text = reader["Password"].ToString();
            }
        }

        private void CLP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_CLP_Logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void button_CLP_Update_Click(object sender, EventArgs e)
        {
            textBox_CLP_Username.Enabled = true;
            textBox_CLP_Name.Enabled = true;
            dateTimePicker_CLP_DoB.Enabled = true;
            textBox_CLP_Address.Enabled = true;
            textBox_CLP_Email.Enabled = true;
            textBox_CLP_Password.Enabled = true;
            button_CLP_Update.Visible = false;
            button_CLP_UpdateOK.Visible = true;
            button_CLP_UpdateCancel.Visible = true;
            label_CLP_ConfirmPassword.Visible = true;
            textBox_CLP_ConfirmPassword.Visible = true;
        }

        private void button_CLP_UpdateCancel_Click(object sender, EventArgs e)
        {
            textBox_CLP_Username.Enabled = false;
            textBox_CLP_Name.Enabled = false;
            dateTimePicker_CLP_DoB.Enabled = false;
            textBox_CLP_Address.Enabled = false;
            textBox_CLP_Email.Enabled = false;
            textBox_CLP_Password.Enabled = false;
            button_CLP_Update.Visible = true;
            button_CLP_UpdateOK.Visible = false;
            button_CLP_UpdateCancel.Visible = false;
            label_CLP_ConfirmPassword.Visible = false;
            textBox_CLP_ConfirmPassword.Visible = false;
        }

        private void button_CLP_UpdateOK_Click(object sender, EventArgs e)
        {
            if (textBox_CLP_Username.Text == "")
            {
                MessageBox.Show("Write your Username!");
            }
            else if (textBox_CLP_Name.Text == "")
            {
                MessageBox.Show("Input an Name!");
            }
            else if (dateTimePicker_CLP_DoB.Text == "")
            {
                MessageBox.Show("Write your Date Of Birth!");
            }
            else if (textBox_CLP_Address.Text == "")
            {
                MessageBox.Show("Write your Address!");
            }
            else if (textBox_CLP_Email.Text == "")
            {
                MessageBox.Show("Write Your Email!");
            }
            else if (textBox_CLP_Password.Text == "")
            {
                MessageBox.Show("Input a Password!");
            }
            else if (textBox_CLP_ConfirmPassword.Text != textBox_CLP_Password.Text)
            {
                MessageBox.Show("Passwords Do not Match!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OBSConnection"].ConnectionString);
                connection.Open();
                string sql = "UPDATE SP_List SET CLPUsrname = '" + textBox_CLP_Username.Text + "', Name = '" + textBox_CLP_Name.Text + "', Date of Birth = '" + dateTimePicker_CLP_DoB.Text + "', Address = '" + textBox_CLP_Address.Text + "' ,Email = '" + textBox_CLP_Email.Text + "', Password = '" + textBox_CLP_Password.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                int check = command.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Information Updated!");
                    textBox_CLP_Username.Enabled = false;
                    textBox_CLP_Name.Enabled = false;
                    dateTimePicker_CLP_DoB.Enabled = false;
                    textBox_CLP_Address.Enabled = false;
                    textBox_CLP_Email.Enabled = false;
                    textBox_CLP_Password.Enabled = false;
                    button_CLP_Update.Visible = true;
                    button_CLP_UpdateOK.Visible = false;
                    button_CLP_UpdateCancel.Visible = false;
                    label_CLP_ConfirmPassword.Visible = false;
                    textBox_CLP_ConfirmPassword.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error!\nTry Again.");

                }
                connection.Close();
            }
         }

        private void Paymentbttn_Click(object sender, EventArgs e)
        {
            PaymentMethod f1 = new PaymentMethod();
            this.Hide();
            f1.Show();
        }
    }
}
