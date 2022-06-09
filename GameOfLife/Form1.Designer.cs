namespace GameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.PictureBox();
            this.SizeNumder = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RunCheckbox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GridCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DelayNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DensityNud = new System.Windows.Forms.NumericUpDown();
            this.TypesCombobox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rectangelsColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangelsColor)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.Location = new System.Drawing.Point(12, 33);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1171, 517);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.SizeChanged += new System.EventHandler(this.Background_SizeChanged);
            // 
            // SizeNumder
            // 
            this.SizeNumder.Location = new System.Drawing.Point(100, 7);
            this.SizeNumder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeNumder.Name = "SizeNumder";
            this.SizeNumder.Size = new System.Drawing.Size(53, 20);
            this.SizeNumder.TabIndex = 1;
            this.SizeNumder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNumder.ValueChanged += new System.EventHandler(this.SizeNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Square size (px):";
            // 
            // RunCheckbox
            // 
            this.RunCheckbox.AutoSize = true;
            this.RunCheckbox.Checked = true;
            this.RunCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunCheckbox.Location = new System.Drawing.Point(487, 10);
            this.RunCheckbox.Name = "RunCheckbox";
            this.RunCheckbox.Size = new System.Drawing.Size(46, 17);
            this.RunCheckbox.TabIndex = 6;
            this.RunCheckbox.Text = "Run";
            this.RunCheckbox.UseVisualStyleBackColor = true;
            this.RunCheckbox.CheckedChanged += new System.EventHandler(this.RunCheckbox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GridCheckbox
            // 
            this.GridCheckbox.AutoSize = true;
            this.GridCheckbox.Checked = true;
            this.GridCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridCheckbox.Location = new System.Drawing.Point(429, 10);
            this.GridCheckbox.Name = "GridCheckbox";
            this.GridCheckbox.Size = new System.Drawing.Size(45, 17);
            this.GridCheckbox.TabIndex = 7;
            this.GridCheckbox.Text = "Grid";
            this.GridCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delay (ms):";
            // 
            // DelayNumber
            // 
            this.DelayNumber.Location = new System.Drawing.Point(231, 7);
            this.DelayNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayNumber.Name = "DelayNumber";
            this.DelayNumber.Size = new System.Drawing.Size(53, 20);
            this.DelayNumber.TabIndex = 9;
            this.DelayNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNumber.ValueChanged += new System.EventHandler(this.DelayNumder_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Density (%):";
            // 
            // DensityNud
            // 
            this.DensityNud.Location = new System.Drawing.Point(357, 7);
            this.DensityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityNud.Name = "DensityNud";
            this.DensityNud.Size = new System.Drawing.Size(53, 20);
            this.DensityNud.TabIndex = 11;
            this.DensityNud.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.DensityNud.ValueChanged += new System.EventHandler(this.DensityNumber_ValueChanged);
            // 
            // TypesCombobox
            // 
            this.TypesCombobox.FormattingEnabled = true;
            this.TypesCombobox.Items.AddRange(new object[] {
            "Beacon",
            "Blinker",
            "Custom",
            "Glider ",
            "Gosper glider gun",
            "HWSS",
            "LWSS",
            "MWSS",
            "Random",
            "Row",
            "Toad",
            "Simkin glider gun",
            "Penta",
            "Pulsar"});
            this.TypesCombobox.Location = new System.Drawing.Point(550, 7);
            this.TypesCombobox.Name = "TypesCombobox";
            this.TypesCombobox.Size = new System.Drawing.Size(121, 21);
            this.TypesCombobox.TabIndex = 12;
            this.TypesCombobox.Text = "Random";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(677, 7);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 13;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Color of rectangels:";
            // 
            // rectangelsColor
            // 
            this.rectangelsColor.BackColor = System.Drawing.Color.Red;
            this.rectangelsColor.Location = new System.Drawing.Point(874, 7);
            this.rectangelsColor.Name = "rectangelsColor";
            this.rectangelsColor.Size = new System.Drawing.Size(18, 18);
            this.rectangelsColor.TabIndex = 15;
            this.rectangelsColor.TabStop = false;
            this.rectangelsColor.Click += new System.EventHandler(this.rectangelsColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 562);
            this.Controls.Add(this.rectangelsColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.TypesCombobox);
            this.Controls.Add(this.DensityNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelayNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridCheckbox);
            this.Controls.Add(this.RunCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeNumder);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life - C# Data Visualization";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangelsColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.NumericUpDown SizeNumder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RunCheckbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox GridCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DelayNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DensityNud;
        private System.Windows.Forms.ComboBox TypesCombobox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox rectangelsColor;
    }
}