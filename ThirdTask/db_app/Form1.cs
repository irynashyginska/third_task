using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace db_app
{
    public partial class Form1 : Form
    {
        private ApplicationContext u;
        private int user_id;
        private User user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.u = new ApplicationContext();
                
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            reg form2 = new reg(this);
            form2.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void open_for_seller(int id)
        {
            table.ColumnCount = 7;
            table.Columns[5].Name = " ";
            table.Columns[6].Name = " ";
            SetupLayout();
            SetupDataGridView();
            int num = 0;
            List<Ship> ships = this.u.Find_ship(id);
            foreach(Ship s in ships)
            {
                string[] a = (s.ToString() + " Edit Delete").Split();
                table.Rows.Add(a);
                table.Rows[num].Tag = s;
                num++;
            }
            buttonPanel.Controls[1].Visible = true;
            buttonPanel.Controls[2].Visible = true;
        }
        private void open_for_buyer()
        {
            table.ColumnCount = 5;
            SetupLayout();
            SetupDataGridView();
            int num = 0;
            List<Ship> ships = this.u.select_all_ships();
            foreach (Ship s in ships)
            {
                string[] a = (s.ToString()).Split();
                table.Rows.Add(a);
                table.Rows[num].Tag = s;
                num++;
            }
            buttonPanel.Controls[1].Visible = false;
            buttonPanel.Controls[2].Visible = false;
        }
        public void update_row(int ind, Ship ship)
        {
            table.Rows[ind].SetValues((ship.ToString() + " Edit Delete").Split());
            table.Rows[ind].Tag = ship;
        }
        public void add_row(Ship sh)
        {
            string[] a = (sh.ToString() + " Edit Delete").Split();
            int ind = table.Rows.Add(a); 
            table.Rows[ind].Tag = sh;
            this.u.add_to_bd(sh);

        }
        void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.ColumnCount == 7)
            {

                if (e.ColumnIndex == table.Columns[5].Index)
                {
                    int ind = e.RowIndex;
                    Ship ship = (Ship)table.Rows[e.RowIndex].Tag;
                    edit form2 = new edit(ship, this, ind);
                    form2.Show();


                }
                else if (e.ColumnIndex == table.Columns[6].Index)
                {
                    if (this.table.SelectedRows.Count > 0 &&
                    this.table.SelectedRows[0].Index !=
                    this.table.Rows.Count - 1)
                    {
                        this.table.Rows.RemoveAt(
                            this.table.SelectedRows[0].Index);
                    }
                }
                else return;
            }
            else return;
        }
        private void SetupLayout()
        {
            this.Size = new Size(900, 500);
            
            addNewRowButton.Text = "Add Row";
            addNewRowButton.AutoSize = true;
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.AutoSize = true;
            deleteRowButton.Location = new Point(160, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            user_account.Location = new Point(310, 10);
            user_account.Click += new EventHandler(user_account_Click);
            user_account.Visible = true;

            searchTextBox.Location = new Point(460, 12);
            searchTextBox.Width = 150;
            searchTextBox.Visible = true;
            searchTextBox.Text = "";

            searchButton.Location = new Point(610, 10);
            searchButton.Visible = true;
            searchButton.Text = "Search";
            searchButton.Click += new EventHandler(searchButton_Click);

            show_all.Location = new Point(760, 10);
            show_all.Visible = true;
            show_all.Text = "Show All";
            show_all.Click += new EventHandler(show_all_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Controls.Add(user_account);
            buttonPanel.Controls.Add(searchTextBox);
            buttonPanel.Controls.Add(searchButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Visible = true;
            this.Controls.Add(this.buttonPanel);
        }
        private void show_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.RowCount - 1; i++)
            {
                table.Rows[i].Visible = true;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0;i<table.RowCount - 1;i++)
                {
                    if((table.Rows[i].Cells[0].Value.ToString().Contains(searchTextBox.Text))
                        || (table.Rows[i].Cells[1].Value.ToString().Contains(searchTextBox.Text))
                        || (table.Rows[i].Cells[2].Value.ToString().Contains(searchTextBox.Text))
                        || (table.Rows[i].Cells[3].Value.ToString().Contains(searchTextBox.Text))
                        || (table.Rows[i].Cells[4].Value.ToString().Contains(searchTextBox.Text)))
                    {
                        table.Rows[i].Visible = true;
                    }
                    else
                    {
                        table.Rows[i].Visible = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void user_account_Click(object sender, EventArgs e)
        {
            table.Visible = false;
            buttonPanel.Visible = false;
            cancel.Visible = true;
            log_out.Visible = true;
            userP.Visible = true;
        }
        void create_user_account()
        {
            userP.ColumnCount = 2;
            userP.Rows.Add("First name", user.First_name);
            userP.Rows.Add("Last name", user.Last_name);
            userP.Rows.Add("Email", user.Email);
            userP.Rows.Add("Role", user.Role);
            userP.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            userP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userP.ColumnHeadersDefaultCellStyle.Font =
                new Font(table.Font, FontStyle.Bold);


            userP.Location = new Point(250, 100);
            userP.Size = new Size(400, 170);
            userP.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            userP.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            userP.GridColor = Color.Black;
            
            cancel.Text = "Cancel";
            cancel.AutoSize = true;
            cancel.Location = new Point(400, 300);
            cancel.Click += new EventHandler(cancel_Click);
            cancel.Visible = false;

            log_out.Text = "Log out";
            log_out.AutoSize = true;
            log_out.Location = new Point(400, 350);
            log_out.Click += new EventHandler(log_out_Click);
            log_out.Visible = false;

            
        }
        private void log_out_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            log_out.Visible = false;
            cancel.Visible = false;
            userP.Visible = false;
            this.Size = new Size(700, 400);
            this.user = null;
            this.user_id = -1;
            clear_table(table);
            clear_table(userP);
        }
        private void clear_table(DataGridView d)
        {
            for(int i = d.RowCount - 2; i>= 0;i--)
            {
                d.Rows.RemoveAt(i);
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            userP.Visible = false;
            table.Visible = true;
            buttonPanel.Visible = true ;
        }
        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                edit form2 = new edit(this);
                form2.Show();
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
        
        public void deleteRowButton_Click(object sender, EventArgs e)
        {
            this.u.delete_ship((Ship)this.table.SelectedRows[0].Tag);
            this.table.Rows.RemoveAt(this.table.SelectedRows[0].Index);
            
            
        }
        private void SetupDataGridView()
        {
            


            table.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            table.ColumnHeadersDefaultCellStyle.Font =
                new Font(table.Font, FontStyle.Bold);



            if (table.ColumnCount == 7)
            {
                table.Size = new Size(700, 250);
                table.Location = new Point(100, 100);
            }
            else
            {
                table.Size = new Size(500, 250);
                table.Location = new Point(200, 100);
            }
                table.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            table.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            table.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            table.GridColor = Color.Black;
            table.RowHeadersVisible = false;

            table.Columns[0].Name = "Name";
            table.Columns[1].Name = "Registration";
            table.Columns[2].Name = "Freight";
            table.Columns[3].Name = "Departure";
            table.Columns[4].Name = "Personnel";
            
            
            table.CellClick += new DataGridViewCellEventHandler(table_CellClick);
            table.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            table.MultiSelect = false;

            table.Visible = true;
           
        }
        void search()
        {

        }
        

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                User user = this.u.find_user(textBox1.Text, textBox2.Text);
                
                this.user_id = user.Id;
                this.user = user;
                create_user_account();
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                if (this.user.Role.Equals("seller"))
                    open_for_seller(user.Id);
                else
                    open_for_buyer();
            }
            catch
            {
                MessageBox.Show("Error, wrong login or password");
            }
        }

        

        
    }
}
