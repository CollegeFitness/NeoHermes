using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace login_and_Register_System
{
    public partial class frmRegister : Form
    {
        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
        public frmRegister()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        bool alreadyExists;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string userNameCheck = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "'";
            cmd = new OleDbCommand(userNameCheck, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("This Username already exists", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                alreadyExists = true;
                con.Close();
            }
            else
            {
                con.Close();
            }

            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "") //Checks to see if someone tried making an account without putting in any data
            {
                //gives an error saying you cannot do that
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (alreadyExists)
            {
                alreadyExists = false;
            }
            else if (txtPassword.Text == txtComPassword.Text)// sees if the passwords match to the normal one and the confirm one
            {
                con.Open(); //opens the database
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + sha256_hash(txtPassword.Text) + "')";//sets register to intert the username and password into the the database table
                cmd = new OleDbCommand(register, con);//writes register to the database of con
                cmd.ExecuteNonQuery();//saves the database
                con.Close();//closes database

                //makes these sections empty for if they want to make another account again
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                //tells the user they have logged in successfully
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //tells the user that the password and confirm password does not match
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //clears the password for it to put in again
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();//puts the typing cursor onto the password textbox
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)//sees if the show password checkbox is clicked to true
            {
                //unchars the password
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                //keeps the password chared
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //takes you to the login page
            new frmLogin().Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
