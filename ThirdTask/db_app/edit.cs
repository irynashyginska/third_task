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
    public partial class edit : Form
    {
        private Ship sh;
        private ApplicationContext con;
        Form1 form;
        private int i;
        bool add = false;
        public edit(Ship sh,Form1 f,int ind)
        {
            this.sh = sh;
            this.con = new ApplicationContext();
            this.form = f;
            this.i = ind;
            InitializeComponent();
        }
        public edit( Form1 f)
        {
            this.sh = new Ship();
            this.con = new ApplicationContext();
            this.form = f;
            this.add = true;
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            if (!this.add)
            {
                for_editing();
            }
            else
                button1.Visible = false;
        }
        private void for_editing()
        {
            textBox6.Visible = false;
            label6.Visible = false;
            button2.Visible = false;
            textBox1.Text = sh.Name;
            textBox2.Text = sh.Registration;
            textBox3.Text = sh.Freight.ToString();
            textBox4.Text = sh.Departure;
            textBox5.Text = sh.Personnel.ToString();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
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

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Npgsql.NpgsqlConnection c = this.con.create_connection(this.con.connectionStr);
            c.Open();
            this.sh.Name = textBox1.Text;
            this.sh.Registration = textBox2.Text;
            this.sh.Freight = double.Parse(textBox3.Text);
            this.sh.Departure = textBox4.Text;
            this.sh.Personnel = int.Parse(textBox5.Text);
            this.form.update_row(this.i,this.sh);
            this.form.Show();
            this.Close();
        }
        public Ship get_ship()
        {
            return this.sh;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Npgsql.NpgsqlConnection c = this.con.create_connection(this.con.connectionStr);
            c.Open();
            this.sh.Id = int.Parse(textBox6.Text);
            this.sh.Name = textBox1.Text;
            this.sh.Registration = textBox2.Text;
            this.sh.Freight = double.Parse(textBox3.Text);
            this.sh.Departure = textBox4.Text;
            this.sh.Personnel = int.Parse(textBox5.Text);
            this.form.add_row(this.sh);
            this.form.Show();
            this.Close();
        }
    }
}
