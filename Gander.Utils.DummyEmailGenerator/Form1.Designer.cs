namespace Gander.Utils.DummyEmailGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.numCountToGenerate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtmDateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStyleViking = new System.Windows.Forms.CheckBox();
            this.chkStyleElf = new System.Windows.Forms.CheckBox();
            this.grpNameStyles = new System.Windows.Forms.GroupBox();
            this.chkStyleNinjaTurtle = new System.Windows.Forms.CheckBox();
            this.chkStyleGreek = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCountToGenerate)).BeginInit();
            this.grpNameStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCountToGenerate
            // 
            this.numCountToGenerate.Location = new System.Drawing.Point(201, 34);
            this.numCountToGenerate.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numCountToGenerate.Name = "numCountToGenerate";
            this.numCountToGenerate.Size = new System.Drawing.Size(78, 20);
            this.numCountToGenerate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many emails to generate?";
            // 
            // dtmDateFrom
            // 
            this.dtmDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateFrom.Location = new System.Drawing.Point(201, 86);
            this.dtmDateFrom.Name = "dtmDateFrom";
            this.dtmDateFrom.Size = new System.Drawing.Size(105, 20);
            this.dtmDateFrom.TabIndex = 5;
            // 
            // dtmDateTo
            // 
            this.dtmDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateTo.Location = new System.Drawing.Point(312, 86);
            this.dtmDateTo.Name = "dtmDateTo";
            this.dtmDateTo.Size = new System.Drawing.Size(105, 20);
            this.dtmDateTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date range";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "PReset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delete existing mail first";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(201, 150);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(154, 20);
            this.txtOutputPath.TabIndex = 11;
            this.txtOutputPath.Text = "E:\\source\\Gander\\Resources\\babypop3server\\temp\\testuser";
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
            // chkStyleViking
            // 
            this.chkStyleViking.AutoSize = true;
            this.chkStyleViking.Location = new System.Drawing.Point(6, 26);
            this.chkStyleViking.Name = "chkStyleViking";
            this.chkStyleViking.Size = new System.Drawing.Size(55, 17);
            this.chkStyleViking.TabIndex = 13;
            this.chkStyleViking.Text = "Viking";
            this.chkStyleViking.UseVisualStyleBackColor = true;
            // 
            // chkStyleElf
            // 
            this.chkStyleElf.AutoSize = true;
            this.chkStyleElf.Location = new System.Drawing.Point(6, 49);
            this.chkStyleElf.Name = "chkStyleElf";
            this.chkStyleElf.Size = new System.Drawing.Size(38, 17);
            this.chkStyleElf.TabIndex = 14;
            this.chkStyleElf.Text = "Elf";
            this.chkStyleElf.UseVisualStyleBackColor = true;
            // 
            // grpNameStyles
            // 
            this.grpNameStyles.Controls.Add(this.chkStyleNinjaTurtle);
            this.grpNameStyles.Controls.Add(this.chkStyleGreek);
            this.grpNameStyles.Controls.Add(this.chkStyleViking);
            this.grpNameStyles.Controls.Add(this.chkStyleElf);
            this.grpNameStyles.Location = new System.Drawing.Point(449, 12);
            this.grpNameStyles.Name = "grpNameStyles";
            this.grpNameStyles.Size = new System.Drawing.Size(139, 192);
            this.grpNameStyles.TabIndex = 16;
            this.grpNameStyles.TabStop = false;
            this.grpNameStyles.Text = "Name Styles";
            // 
            // chkStyleNinjaTurtle
            // 
            this.chkStyleNinjaTurtle.AutoSize = true;
            this.chkStyleNinjaTurtle.Enabled = false;
            this.chkStyleNinjaTurtle.Location = new System.Drawing.Point(6, 70);
            this.chkStyleNinjaTurtle.Name = "chkStyleNinjaTurtle";
            this.chkStyleNinjaTurtle.Size = new System.Drawing.Size(80, 17);
            this.chkStyleNinjaTurtle.TabIndex = 19;
            this.chkStyleNinjaTurtle.Text = "Ninja Turtle";
            this.chkStyleNinjaTurtle.UseVisualStyleBackColor = true;
            // 
            // chkStyleGreek
            // 
            this.chkStyleGreek.AutoSize = true;
            this.chkStyleGreek.Enabled = false;
            this.chkStyleGreek.Location = new System.Drawing.Point(6, 93);
            this.chkStyleGreek.Name = "chkStyleGreek";
            this.chkStyleGreek.Size = new System.Drawing.Size(55, 17);
            this.chkStyleGreek.TabIndex = 18;
            this.chkStyleGreek.Text = "Greek";
            this.chkStyleGreek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 359);
            this.Controls.Add(this.grpNameStyles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmDateTo);
            this.Controls.Add(this.dtmDateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCountToGenerate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCountToGenerate)).EndInit();
            this.grpNameStyles.ResumeLayout(false);
            this.grpNameStyles.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStyleViking;
        private System.Windows.Forms.CheckBox chkStyleElf;
        private System.Windows.Forms.GroupBox grpNameStyles;
        private System.Windows.Forms.CheckBox chkStyleGreek;
        private System.Windows.Forms.CheckBox chkStyleNinjaTurtle;
    }
}

