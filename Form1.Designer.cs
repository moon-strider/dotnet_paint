namespace VGE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChooseCursor = new System.Windows.Forms.Button();
            this.buttonChooseRect = new System.Windows.Forms.Button();
            this.buttonChooseEllipse = new System.Windows.Forms.Button();
            this.buttonChooseTriangle = new System.Windows.Forms.Button();
            this.buttonChooseLine = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 380);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 472);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1031, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // buttonChooseCursor
            // 
            this.buttonChooseCursor.Enabled = false;
            this.buttonChooseCursor.Location = new System.Drawing.Point(12, 12);
            this.buttonChooseCursor.Name = "buttonChooseCursor";
            this.buttonChooseCursor.Size = new System.Drawing.Size(83, 73);
            this.buttonChooseCursor.TabIndex = 3;
            this.buttonChooseCursor.Text = "Cursor";
            this.buttonChooseCursor.UseVisualStyleBackColor = true;
            // 
            // buttonChooseRect
            // 
            this.buttonChooseRect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonChooseRect.Location = new System.Drawing.Point(101, 12);
            this.buttonChooseRect.Name = "buttonChooseRect";
            this.buttonChooseRect.Size = new System.Drawing.Size(83, 73);
            this.buttonChooseRect.TabIndex = 4;
            this.buttonChooseRect.Text = "Rect";
            this.buttonChooseRect.UseVisualStyleBackColor = false;
            this.buttonChooseRect.Click += new System.EventHandler(this.buttonChooseRect_Click);
            // 
            // buttonChooseEllipse
            // 
            this.buttonChooseEllipse.Location = new System.Drawing.Point(190, 12);
            this.buttonChooseEllipse.Name = "buttonChooseEllipse";
            this.buttonChooseEllipse.Size = new System.Drawing.Size(83, 73);
            this.buttonChooseEllipse.TabIndex = 5;
            this.buttonChooseEllipse.Text = "Ellipse";
            this.buttonChooseEllipse.UseVisualStyleBackColor = true;
            this.buttonChooseEllipse.Click += new System.EventHandler(this.buttonChooseEllipse_Click);
            // 
            // buttonChooseTriangle
            // 
            this.buttonChooseTriangle.Enabled = false;
            this.buttonChooseTriangle.Location = new System.Drawing.Point(279, 12);
            this.buttonChooseTriangle.Name = "buttonChooseTriangle";
            this.buttonChooseTriangle.Size = new System.Drawing.Size(83, 73);
            this.buttonChooseTriangle.TabIndex = 6;
            this.buttonChooseTriangle.Text = "Triangle";
            this.buttonChooseTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonChooseLine
            // 
            this.buttonChooseLine.Enabled = false;
            this.buttonChooseLine.Location = new System.Drawing.Point(368, 12);
            this.buttonChooseLine.Name = "buttonChooseLine";
            this.buttonChooseLine.Size = new System.Drawing.Size(83, 73);
            this.buttonChooseLine.TabIndex = 7;
            this.buttonChooseLine.Text = "Line";
            this.buttonChooseLine.UseVisualStyleBackColor = true;
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(457, 30);
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(109, 45);
            this.trackBarThickness.TabIndex = 8;
            this.trackBarThickness.Value = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1134, 575);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.buttonChooseLine);
            this.Controls.Add(this.buttonChooseTriangle);
            this.Controls.Add(this.buttonChooseEllipse);
            this.Controls.Add(this.buttonChooseRect);
            this.Controls.Add(this.buttonChooseCursor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button buttonChooseCursor;
        private Button buttonChooseRect;
        private Button buttonChooseEllipse;
        private Button buttonChooseTriangle;
        private Button buttonChooseLine;
        private TrackBar trackBarThickness;
    }
}