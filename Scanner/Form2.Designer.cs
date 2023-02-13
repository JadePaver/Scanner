namespace Scanner
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Show = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show.BackgroundImage")));
            this.Show.Location = new System.Drawing.Point(293, 80);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(25, 25);
            this.Show.TabIndex = 0;
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click_1);
            // 
            // Hide
            // 
            this.Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide.BackgroundImage")));
            this.Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Hide.Location = new System.Drawing.Point(292, 80);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(25, 25);
            this.Hide.TabIndex = 1;
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(158, 51);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(128, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(158, 80);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(128, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(204, 147);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(82, 25);
            this.Login.TabIndex = 4;
            this.Login.Text = "Enter";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Hide);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 30);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtUser;
        private TextBox textBox2;
        private Button Login;
        private Label label1;
        private Button Show;
        private Button Hide;
        private Label label2;
        private TextBox txtPass;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}