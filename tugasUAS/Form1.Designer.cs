namespace tugasUAS
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Indigo;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnHitung, "btnHitung");
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Indigo;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.ForeColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::tugasUAS.Properties.Resources._5571983;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

