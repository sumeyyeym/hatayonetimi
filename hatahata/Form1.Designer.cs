namespace hatahata
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHataYonetimsiz = new System.Windows.Forms.Button();
            this.btnHataYonetimli = new System.Windows.Forms.Button();
            this.btnHataYonetimliMesaj = new System.Windows.Forms.Button();
            this.btnHataYonetimliMesaj1 = new System.Windows.Forms.Button();
            this.btnHataYonetimliFinally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnHataYonetimsiz
            // 
            this.btnHataYonetimsiz.Location = new System.Drawing.Point(55, 39);
            this.btnHataYonetimsiz.Name = "btnHataYonetimsiz";
            this.btnHataYonetimsiz.Size = new System.Drawing.Size(75, 23);
            this.btnHataYonetimsiz.TabIndex = 1;
            this.btnHataYonetimsiz.Text = "Hata Yönetimsiz";
            this.btnHataYonetimsiz.UseVisualStyleBackColor = true;
            this.btnHataYonetimsiz.Click += new System.EventHandler(this.BtnHataYonetimsiz_Click);
            // 
            // btnHataYonetimli
            // 
            this.btnHataYonetimli.Location = new System.Drawing.Point(55, 68);
            this.btnHataYonetimli.Name = "btnHataYonetimli";
            this.btnHataYonetimli.Size = new System.Drawing.Size(75, 23);
            this.btnHataYonetimli.TabIndex = 2;
            this.btnHataYonetimli.Text = "Hata Yönetimli";
            this.btnHataYonetimli.UseVisualStyleBackColor = true;
            this.btnHataYonetimli.Click += new System.EventHandler(this.BtnHataYonetimli_Click);
            // 
            // btnHataYonetimliMesaj
            // 
            this.btnHataYonetimliMesaj.Location = new System.Drawing.Point(55, 97);
            this.btnHataYonetimliMesaj.Name = "btnHataYonetimliMesaj";
            this.btnHataYonetimliMesaj.Size = new System.Drawing.Size(75, 23);
            this.btnHataYonetimliMesaj.TabIndex = 3;
            this.btnHataYonetimliMesaj.Text = "Hata Yönetimli - Mesaj";
            this.btnHataYonetimliMesaj.UseVisualStyleBackColor = true;
            this.btnHataYonetimliMesaj.Click += new System.EventHandler(this.BtnHataYonetimliMesaj_Click);
            // 
            // btnHataYonetimliMesaj1
            // 
            this.btnHataYonetimliMesaj1.Location = new System.Drawing.Point(55, 126);
            this.btnHataYonetimliMesaj1.Name = "btnHataYonetimliMesaj1";
            this.btnHataYonetimliMesaj1.Size = new System.Drawing.Size(75, 23);
            this.btnHataYonetimliMesaj1.TabIndex = 4;
            this.btnHataYonetimliMesaj1.Text = "Hata Yönetimli - Mesaj";
            this.btnHataYonetimliMesaj1.UseVisualStyleBackColor = true;
            this.btnHataYonetimliMesaj1.Click += new System.EventHandler(this.BtnHataYonetimliMesaj1_Click);
            // 
            // btnHataYonetimliFinally
            // 
            this.btnHataYonetimliFinally.Location = new System.Drawing.Point(55, 155);
            this.btnHataYonetimliFinally.Name = "btnHataYonetimliFinally";
            this.btnHataYonetimliFinally.Size = new System.Drawing.Size(75, 23);
            this.btnHataYonetimliFinally.TabIndex = 5;
            this.btnHataYonetimliFinally.Text = "Hata Yönetimli - Finally";
            this.btnHataYonetimliFinally.UseVisualStyleBackColor = true;
            this.btnHataYonetimliFinally.Click += new System.EventHandler(this.BtnHataYonetimliFinally_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHataYonetimliFinally);
            this.Controls.Add(this.btnHataYonetimliMesaj1);
            this.Controls.Add(this.btnHataYonetimliMesaj);
            this.Controls.Add(this.btnHataYonetimli);
            this.Controls.Add(this.btnHataYonetimsiz);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHataYonetimsiz;
        private System.Windows.Forms.Button btnHataYonetimli;
        private System.Windows.Forms.Button btnHataYonetimliMesaj;
        private System.Windows.Forms.Button btnHataYonetimliMesaj1;
        private System.Windows.Forms.Button btnHataYonetimliFinally;
    }
}

