namespace WindowsFormsApp10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MyTextBox = new System.Windows.Forms.TextBox();
            this.MyProgressbar = new System.Windows.Forms.ProgressBar();
            this.MyPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.MyLabelScore = new System.Windows.Forms.Label();
            this.MyFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MyLabelFilename = new System.Windows.Forms.Label();
            this.MyLabelPosition = new System.Windows.Forms.Label();
            this.MyLabelMaximum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox_2)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTextBox
            // 
            this.MyTextBox.AcceptsReturn = true;
            this.MyTextBox.AcceptsTab = true;
            this.MyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyTextBox.Enabled = false;
            this.MyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTextBox.ForeColor = System.Drawing.Color.White;
            this.MyTextBox.Location = new System.Drawing.Point(70, 20);
            this.MyTextBox.Margin = new System.Windows.Forms.Padding(100, 100, 100, 100);
            this.MyTextBox.Multiline = true;
            this.MyTextBox.Name = "MyTextBox";
            this.MyTextBox.ReadOnly = true;
            this.MyTextBox.Size = new System.Drawing.Size(473, 247);
            this.MyTextBox.TabIndex = 1;
            this.MyTextBox.Text = resources.GetString("MyTextBox.Text");
            this.MyTextBox.TextChanged += new System.EventHandler(this.MyTextBox_TextChanged);
            // 
            // MyProgressbar
            // 
            this.MyProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyProgressbar.Location = new System.Drawing.Point(12, 435);
            this.MyProgressbar.Name = "MyProgressbar";
            this.MyProgressbar.Size = new System.Drawing.Size(624, 23);
            this.MyProgressbar.Step = 100;
            this.MyProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MyProgressbar.TabIndex = 1;
            // 
            // MyPictureBox_2
            // 
            this.MyPictureBox_2.BackColor = System.Drawing.Color.Black;
            this.MyPictureBox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyPictureBox_2.Location = new System.Drawing.Point(-2, 0);
            this.MyPictureBox_2.Name = "MyPictureBox_2";
            this.MyPictureBox_2.Size = new System.Drawing.Size(586, 477);
            this.MyPictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MyPictureBox_2.TabIndex = 4;
            this.MyPictureBox_2.TabStop = false;
            this.MyPictureBox_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMouseDown);
            this.MyPictureBox_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMouseMove);
            this.MyPictureBox_2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MyMouseWheel);
            // 
            // MyLabelScore
            // 
            this.MyLabelScore.AutoSize = true;
            this.MyLabelScore.BackColor = System.Drawing.Color.Transparent;
            this.MyLabelScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyLabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabelScore.ForeColor = System.Drawing.Color.Yellow;
            this.MyLabelScore.Location = new System.Drawing.Point(591, 0);
            this.MyLabelScore.Name = "MyLabelScore";
            this.MyLabelScore.Size = new System.Drawing.Size(57, 55);
            this.MyLabelScore.TabIndex = 5;
            this.MyLabelScore.Text = "X";
            this.MyLabelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MyLabelFilename
            // 
            this.MyLabelFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MyLabelFilename.AutoSize = true;
            this.MyLabelFilename.BackColor = System.Drawing.Color.Transparent;
            this.MyLabelFilename.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabelFilename.ForeColor = System.Drawing.Color.Yellow;
            this.MyLabelFilename.Location = new System.Drawing.Point(12, 399);
            this.MyLabelFilename.Name = "MyLabelFilename";
            this.MyLabelFilename.Size = new System.Drawing.Size(219, 33);
            this.MyLabelFilename.TabIndex = 6;
            this.MyLabelFilename.Text = "##filename##";
            this.MyLabelFilename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyLabelPosition
            // 
            this.MyLabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MyLabelPosition.AutoSize = true;
            this.MyLabelPosition.BackColor = System.Drawing.Color.Transparent;
            this.MyLabelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabelPosition.ForeColor = System.Drawing.Color.Yellow;
            this.MyLabelPosition.Location = new System.Drawing.Point(12, 366);
            this.MyLabelPosition.Name = "MyLabelPosition";
            this.MyLabelPosition.Size = new System.Drawing.Size(192, 33);
            this.MyLabelPosition.TabIndex = 7;
            this.MyLabelPosition.Text = "##position##";
            this.MyLabelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyLabelMaximum
            // 
            this.MyLabelMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MyLabelMaximum.AutoSize = true;
            this.MyLabelMaximum.BackColor = System.Drawing.Color.Transparent;
            this.MyLabelMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyLabelMaximum.ForeColor = System.Drawing.Color.Yellow;
            this.MyLabelMaximum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyLabelMaximum.Location = new System.Drawing.Point(417, 366);
            this.MyLabelMaximum.Name = "MyLabelMaximum";
            this.MyLabelMaximum.Size = new System.Drawing.Size(219, 33);
            this.MyLabelMaximum.TabIndex = 8;
            this.MyLabelMaximum.Text = "##maximum##";
            this.MyLabelMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 470);
            this.Controls.Add(this.MyLabelMaximum);
            this.Controls.Add(this.MyLabelPosition);
            this.Controls.Add(this.MyLabelFilename);
            this.Controls.Add(this.MyLabelScore);
            this.Controls.Add(this.MyProgressbar);
            this.Controls.Add(this.MyTextBox);
            this.Controls.Add(this.MyPictureBox_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MyTextBox;
        private System.Windows.Forms.ProgressBar MyProgressbar;
        private System.Windows.Forms.PictureBox MyPictureBox_2;
        private System.Windows.Forms.Label MyLabelScore;
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowserDialog;
        private System.Windows.Forms.Label MyLabelFilename;
        private System.Windows.Forms.Label MyLabelPosition;
        private System.Windows.Forms.Label MyLabelMaximum;
    }
}

