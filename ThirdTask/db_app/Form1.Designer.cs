namespace db_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        
        #region Windows Form Designer generated code


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManual = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.addNewRowButton = new System.Windows.Forms.Button();
            this.user_account = new System.Windows.Forms.Button();
            this.userP = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.show_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(0, 0);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 23);
            this.buttonManual.TabIndex = 0;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 23);
            this.login.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(464, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "register";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Location = new System.Drawing.Point(464, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(224, 53);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(240, 150);
            this.table.TabIndex = 8;
            this.table.Visible = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Azure;
            this.buttonPanel.Controls.Add(this.show_all);
            this.buttonPanel.Controls.Add(this.searchTextBox);
            this.buttonPanel.Controls.Add(this.searchButton);
            this.buttonPanel.Controls.Add(this.user_account);
            this.buttonPanel.Controls.Add(this.deleteRowButton);
            this.buttonPanel.Controls.Add(this.addNewRowButton);
            this.buttonPanel.Location = new System.Drawing.Point(789, 202);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(229, 221);
            this.buttonPanel.TabIndex = 9;
            this.buttonPanel.Visible = false;
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.deleteRowButton.Location = new System.Drawing.Point(27, 74);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(85, 39);
            this.deleteRowButton.TabIndex = 1;
            this.deleteRowButton.Text = "button6";
            this.deleteRowButton.UseVisualStyleBackColor = false;
            // 
            // addNewRowButton
            // 
            this.addNewRowButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addNewRowButton.Location = new System.Drawing.Point(27, 20);
            this.addNewRowButton.Name = "addNewRowButton";
            this.addNewRowButton.Size = new System.Drawing.Size(85, 41);
            this.addNewRowButton.TabIndex = 0;
            this.addNewRowButton.Text = "button5";
            this.addNewRowButton.UseVisualStyleBackColor = false;
            // 
            // user_account
            // 
            this.user_account.AutoSize = true;
            this.user_account.BackColor = System.Drawing.Color.PaleTurquoise;
            this.user_account.Location = new System.Drawing.Point(118, 20);
            this.user_account.Name = "user_account";
            this.user_account.Size = new System.Drawing.Size(116, 41);
            this.user_account.TabIndex = 2;
            this.user_account.Text = "User Account";
            this.user_account.UseVisualStyleBackColor = false;
            // 
            // userP
            // 
            this.userP.BackgroundColor = System.Drawing.Color.Azure;
            this.userP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userP.ColumnHeadersVisible = false;
            this.userP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.userP.Location = new System.Drawing.Point(200, 240);
            this.userP.Name = "userP";
            this.userP.RowHeadersVisible = false;
            this.userP.RowTemplate.Height = 28;
            this.userP.Size = new System.Drawing.Size(402, 214);
            this.userP.TabIndex = 10;
            this.userP.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Location = new System.Drawing.Point(70, 101);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 30);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            // 
            // log_out
            // 
            this.log_out.AutoSize = true;
            this.log_out.Location = new System.Drawing.Point(70, 143);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(75, 30);
            this.log_out.TabIndex = 12;
            this.log_out.Text = "button6";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchButton.Location = new System.Drawing.Point(27, 133);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(27, 171);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchTextBox.TabIndex = 5;
            // 
            // show_all
            // 
            this.show_all.AutoSize = true;
            this.show_all.BackColor = System.Drawing.Color.PaleTurquoise;
            this.show_all.Location = new System.Drawing.Point(142, 80);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(75, 30);
            this.show_all.TabIndex = 6;
            this.show_all.Text = "button1";
            this.show_all.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1030, 578);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.userP);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button addNewRowButton;
        private System.Windows.Forms.Button user_account;
        private System.Windows.Forms.DataGridView userP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button show_all;
    }
}

