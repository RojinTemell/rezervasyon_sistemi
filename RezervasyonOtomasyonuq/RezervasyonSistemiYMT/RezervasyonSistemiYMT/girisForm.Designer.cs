namespace RezervasyonSistemiYMT
{
    partial class girisForm
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
            this.btnYoneticiGrs = new System.Windows.Forms.Button();
            this.btnRezYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYoneticiGrs
            // 
            this.btnYoneticiGrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGrs.Location = new System.Drawing.Point(200, 183);
            this.btnYoneticiGrs.Name = "btnYoneticiGrs";
            this.btnYoneticiGrs.Size = new System.Drawing.Size(148, 52);
            this.btnYoneticiGrs.TabIndex = 0;
            this.btnYoneticiGrs.Text = "Yönetici Girişi ";
            this.btnYoneticiGrs.UseVisualStyleBackColor = true;
            this.btnYoneticiGrs.Click += new System.EventHandler(this.btnYoneticiGrs_Click);
            // 
            // btnRezYap
            // 
            this.btnRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezYap.Location = new System.Drawing.Point(403, 183);
            this.btnRezYap.Name = "btnRezYap";
            this.btnRezYap.Size = new System.Drawing.Size(148, 52);
            this.btnRezYap.TabIndex = 1;
            this.btnRezYap.Text = "Rezervasyon Yap";
            this.btnRezYap.UseVisualStyleBackColor = true;
            this.btnRezYap.Click += new System.EventHandler(this.btnRezYap_Click);
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 398);
            this.Controls.Add(this.btnRezYap);
            this.Controls.Add(this.btnYoneticiGrs);
            this.Name = "girisForm";
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiGrs;
        private System.Windows.Forms.Button btnRezYap;
    }
}