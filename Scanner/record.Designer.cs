namespace Scanner
{
    partial class record
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNoOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 440);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = " ID No. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataDept,
            this.TimeInAM,
            this.TimeOutAM,
            this.TimeInPM,
            this.TimeOutPM,
            this.TotalHrs,
            this.DataStatus,
            this.DataNoOfDays});
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(842, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(437, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 440);
            this.panel2.TabIndex = 2;
            // 
            // DataDept
            // 
            this.DataDept.HeaderText = "Department";
            this.DataDept.Name = "DataDept";
            // 
            // TimeInAM
            // 
            this.TimeInAM.HeaderText = "Time In AM";
            this.TimeInAM.Name = "TimeInAM";
            // 
            // TimeOutAM
            // 
            this.TimeOutAM.HeaderText = "Time Out AM";
            this.TimeOutAM.Name = "TimeOutAM";
            // 
            // TimeInPM
            // 
            this.TimeInPM.HeaderText = "Time In PM";
            this.TimeInPM.Name = "TimeInPM";
            // 
            // TimeOutPM
            // 
            this.TimeOutPM.HeaderText = "Time Out PM";
            this.TimeOutPM.Name = "TimeOutPM";
            // 
            // TotalHrs
            // 
            this.TotalHrs.HeaderText = "Total Hours";
            this.TotalHrs.Name = "TotalHrs";
            // 
            // DataStatus
            // 
            this.DataStatus.HeaderText = "Status";
            this.DataStatus.Name = "DataStatus";
            // 
            // DataNoOfDays
            // 
            this.DataNoOfDays.HeaderText = "No. of Days";
            this.DataNoOfDays.Name = "DataNoOfDays";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(297, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "record";
            this.Text = "record";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn DataDept;
        private DataGridViewTextBoxColumn TimeInAM;
        private DataGridViewTextBoxColumn TimeOutAM;
        private DataGridViewTextBoxColumn TimeInPM;
        private DataGridViewTextBoxColumn TimeOutPM;
        private DataGridViewTextBoxColumn TotalHrs;
        private DataGridViewTextBoxColumn DataStatus;
        private DataGridViewTextBoxColumn DataNoOfDays;
        private Button btnLogout;
    }
}