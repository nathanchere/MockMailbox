namespace Gander.Utils.DummyEmailGenerator
{
    partial class frmTestDataGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.numCountToGenerate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtmDateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCountToGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCountToGenerate
            // 
            this.numCountToGenerate.Location = new System.Drawing.Point(142, 34);
            this.numCountToGenerate.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numCountToGenerate.Name = "numCountToGenerate";
            this.numCountToGenerate.Size = new System.Drawing.Size(78, 20);
            this.numCountToGenerate.TabIndex = 1;
            this.numCountToGenerate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many emails?";
            // 
            // dtmDateFrom
            // 
            this.dtmDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateFrom.Location = new System.Drawing.Point(142, 66);
            this.dtmDateFrom.Name = "dtmDateFrom";
            this.dtmDateFrom.Size = new System.Drawing.Size(105, 20);
            this.dtmDateFrom.TabIndex = 5;
            this.dtmDateFrom.Value = new System.DateTime(2012, 1, 1, 20, 41, 0, 0);
            // 
            // dtmDateTo
            // 
            this.dtmDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateTo.Location = new System.Drawing.Point(142, 92);
            this.dtmDateTo.Name = "dtmDateTo";
            this.dtmDateTo.Size = new System.Drawing.Size(105, 20);
            this.dtmDateTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date range";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(142, 150);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(154, 20);
            this.txtOutputPath.TabIndex = 11;
            this.txtOutputPath.Text = "E:\\source\\Gander\\Resources\\babypop3server\\temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmDateTo);
            this.Controls.Add(this.dtmDateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCountToGenerate);
            this.Controls.Add(this.button1);
            this.Name = "frmTestDataGenerator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCountToGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numCountToGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmDateFrom;
        private System.Windows.Forms.DateTimePicker dtmDateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label5;
    }
}

