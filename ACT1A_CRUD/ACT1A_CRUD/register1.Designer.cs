namespace ACT1A_CRUD
{
    partial class register1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnSignIn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(106, 35);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 14;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(61, 164);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(61, 240);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 17;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(65, 312);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 20;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(65, 197);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your username";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 21;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.DimGray;
            txtUserName.Location = new Point(61, 264);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter your username";
            txtUserName.Size = new Size(226, 25);
            txtUserName.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(61, 336);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.MenuHighlight;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(65, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(226, 46);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.MenuHighlight;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(65, 432);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(226, 46);
            btnSignIn.TabIndex = 25;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(126, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 70);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // register1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 500);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignIn);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register1";
            Text = "register1";
            Load += register1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnSignIn;
        private PictureBox pictureBox1;
    }
}