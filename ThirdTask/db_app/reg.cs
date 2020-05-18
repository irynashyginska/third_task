using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_app
{
    public partial class reg : Form
    {
        Form1 form;
        User user;
        ApplicationContext con;
        public reg()
        {
            InitializeComponent();
            this.user = new User();
            this.con = new ApplicationContext();
        }
        public reg(Form1 f)
        {
            this.form = f;
            InitializeComponent();
            this.user = new User();
            this.con = new ApplicationContext();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.form.Show();
            Close();
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }


        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.user.Role = "seller";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.user.Role = "buyer";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
                try
                {
                    Random r = new Random();
                    int id = r.Next(100000);
                    Npgsql.NpgsqlConnection c = this.con.create_connection(this.con.connectionStr);
                    c.Open();
                    this.user.First_name = textBox1.Text;
                    this.user.Last_name = textBox2.Text;
                    this.user.Email = textBox3.Text;
                    this.user.Password = textBox4.Text;
                    this.user.Id = id;
                    this.user.add_to_bd(c);

                }
                catch
                {
                    MessageBox.Show("Check your incoming data");
                    
                }
                
            
            this.form.Show();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.form.Show();
            Close();
        }
    }
}
