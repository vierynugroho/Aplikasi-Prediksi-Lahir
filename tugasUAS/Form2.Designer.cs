namespace tugasUAS
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
            this.boxInputNama = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLihatHasil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxInputNama
            // 
            this.boxInputNama.Location = new System.Drawing.Point(203, 190);
            this.boxInputNama.Margin = new System.Windows.Forms.Padding(2);
            this.boxInputNama.Name = "boxInputNama";
            this.boxInputNama.Size = new System.Drawing.Size(197, 20);
            this.boxInputNama.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("orange juice", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Indigo;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(75, -19);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(397, 77);
            this.title.TabIndex = 1;
            this.title.Text = "HITUNG PREDIKSI LAHIR";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Ibu";
            // 
            // btnLihatHasil
            // 
            this.btnLihatHasil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLihatHasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLihatHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatHasil.ForeColor = System.Drawing.Color.Indigo;
            this.btnLihatHasil.Location = new System.Drawing.Point(315, 214);
            this.btnLihatHasil.Margin = new System.Windows.Forms.Padding(2);
            this.btnLihatHasil.Name = "btnLihatHasil";
            this.btnLihatHasil.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.btnLihatHasil.Size = new System.Drawing.Size(85, 28);
            this.btnLihatHasil.TabIndex = 3;
            this.btnLihatHasil.Text = "Lihat Hasil";
            this.btnLihatHasil.UseVisualStyleBackColor = false;
            this.btnLihatHasil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(103, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 71);
            this.label3.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::tugasUAS.Properties.Resources._5571983;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnLihatHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.boxInputNama);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K7 | Hitung Prediksi Lahir";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxInputNama;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLihatHasil;
        private System.Windows.Forms.Label label3;
    }
}