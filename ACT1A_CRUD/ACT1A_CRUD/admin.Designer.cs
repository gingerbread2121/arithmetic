namespace ACT1A_CRUD
{
    partial class Admin
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            label6 = new Label();
            btnLogout = new Button();
            btnSearch = new Button();
            panel1 = new Panel();
            cbRole = new ComboBox();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.DimGray;
            txtID.Location = new Point(91, 97);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(226, 25);
            txtID.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(92, 163);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(90, 228);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(90, 296);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 20;
            txtPassword.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(91, 73);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 22;
            label2.Text = "#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(91, 139);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 23;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(90, 204);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 24;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(89, 272);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 25;
            label4.Text = "Password ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(89, 337);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 26;
            label5.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(89, 424);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 46);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add Acoount";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(89, 494);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 46);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkRed;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(89, 567);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(226, 46);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(410, 63);
            label6.Name = "label6";
            label6.Size = new Size(139, 37);
            label6.TabIndex = 30;
            label6.Text = "Welcome";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(773, 73);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 46);
            btnLogout.TabIndex = 31;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(773, 141);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 24);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(92, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 33;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(92, 361);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(224, 23);
            cbRole.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 409);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(410, 141);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(343, 23);
            txtSearch.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(93, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(91, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(91, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 37;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(93, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 38;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(413, 178);
            panel6.Name = "panel6";
            panel6.Size = new Size(339, 10);
            panel6.TabIndex = 39;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 645);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(cbRole);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(label6);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "admin";
            Text = "admin";
            Load += admin_Load_1;
            Click += admin_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Label label6;
        private Button btnLogout;
        private Button btnSearch;
        private Panel panel1;
        private ComboBox cbRole;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}