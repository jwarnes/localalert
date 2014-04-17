namespace DwmTest
{
    partial class MainForm
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
            this.lstWindows = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.cbRect = new System.Windows.Forms.CheckBox();
            this.txtX = new System.Windows.Forms.NumericUpDown();
            this.txtY = new System.Windows.Forms.NumericUpDown();
            this.txtW = new System.Windows.Forms.NumericUpDown();
            this.txtH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Alert";
            // 
            // lstWindows
            // 
            this.lstWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWindows.DisplayMember = "Title";
            this.lstWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Location = new System.Drawing.Point(144, 63);
            this.lstWindows.Margin = new System.Windows.Forms.Padding(4);
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(468, 24);
            this.lstWindows.TabIndex = 3;
            this.lstWindows.ValueMember = "Title";
            this.lstWindows.SelectedIndexChanged += new System.EventHandler(this.lstWindows_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a window:";
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(23, 101);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(687, 238);
            this.image.TabIndex = 5;
            this.image.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(621, 63);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(481, 16);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 33);
            this.btnCapture.TabIndex = 8;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // cbRect
            // 
            this.cbRect.AutoSize = true;
            this.cbRect.Location = new System.Drawing.Point(161, 26);
            this.cbRect.Name = "cbRect";
            this.cbRect.Size = new System.Drawing.Size(59, 21);
            this.cbRect.TabIndex = 14;
            this.cbRect.Text = "Rect";
            this.cbRect.UseVisualStyleBackColor = true;
            this.cbRect.CheckedChanged += new System.EventHandler(this.cbRect_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(233, 25);
            this.txtX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(56, 22);
            this.txtX.TabIndex = 15;
            this.txtX.Validated += new System.EventHandler(this.cbRect_CheckedChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(295, 24);
            this.txtY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(56, 22);
            this.txtY.TabIndex = 16;
            this.txtY.Validated += new System.EventHandler(this.cbRect_CheckedChanged);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(357, 24);
            this.txtW.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(56, 22);
            this.txtW.TabIndex = 17;
            this.txtW.Validated += new System.EventHandler(this.cbRect_CheckedChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(419, 25);
            this.txtH.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(56, 22);
            this.txtH.TabIndex = 18;
            this.txtH.Validated += new System.EventHandler(this.cbRect_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 377);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.cbRect);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstWindows);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LocalAlert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Validated += new System.EventHandler(this.cbRect_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.CheckBox cbRect;
        private System.Windows.Forms.NumericUpDown txtX;
        private System.Windows.Forms.NumericUpDown txtY;
        private System.Windows.Forms.NumericUpDown txtW;
        private System.Windows.Forms.NumericUpDown txtH;

    }
}

