namespace Scanner
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.News = new System.Windows.Forms.GroupBox();
            this.Board = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Weather = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.News.SuspendLayout();
            this.Board.SuspendLayout();
            this.Weather.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // News
            // 
            this.News.BackColor = System.Drawing.Color.YellowGreen;
            this.News.Controls.Add(this.label1);
            this.News.Location = new System.Drawing.Point(549, 41);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(218, 242);
            this.News.TabIndex = 1;
            this.News.TabStop = false;
            this.News.Text = "News";
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.SpringGreen;
            this.Board.Controls.Add(this.label2);
            this.Board.Location = new System.Drawing.Point(23, 41);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(504, 397);
            this.Board.TabIndex = 2;
            this.Board.TabStop = false;
            this.Board.Text = "Board";
            this.Board.MouseHover += new System.EventHandler(this.Board_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Weather
            // 
            this.Weather.BackColor = System.Drawing.Color.BlueViolet;
            this.Weather.Controls.Add(this.label3);
            this.Weather.Location = new System.Drawing.Point(549, 308);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(218, 130);
            this.Weather.TabIndex = 2;
            this.Weather.TabStop = false;
            this.Weather.Text = "Weather";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Weather);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.News);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.News.ResumeLayout(false);
            this.News.PerformLayout();
            this.Board.ResumeLayout(false);
            this.Board.PerformLayout();
            this.Weather.ResumeLayout(false);
            this.Weather.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox News;
        private GroupBox Board;
        private Label label2;
        private GroupBox Weather;
        private Label label3;
    }
}