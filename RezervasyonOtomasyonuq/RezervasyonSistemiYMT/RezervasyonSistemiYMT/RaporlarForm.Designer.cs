namespace RezervasyonSistemiYMT
{
    partial class RaporlarForm
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
            this.dgMusteri = new System.Windows.Forms.DataGridView();
            this.dgRez = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRez)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMusteri
            // 
            this.dgMusteri.BackgroundColor = System.Drawing.Color.White;
            this.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteri.Location = new System.Drawing.Point(22, 37);
            this.dgMusteri.Name = "dgMusteri";
            this.dgMusteri.RowHeadersWidth = 51;
            this.dgMusteri.RowTemplate.Height = 24;
            this.dgMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMusteri.Size = new System.Drawing.Size(492, 396);
            this.dgMusteri.TabIndex = 0;
            // 
            // dgRez
            // 
            this.dgRez.BackgroundColor = System.Drawing.Color.White;
            this.dgRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRez.Location = new System.Drawing.Point(543, 37);
            this.dgRez.Name = "dgRez";
            this.dgRez.RowHeadersWidth = 51;
            this.dgRez.RowTemplate.Height = 24;
            this.dgRez.Size = new System.Drawing.Size(873, 396);
            this.dgRez.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(975, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgRez);
            this.Controls.Add(this.dgMusteri);
            this.Name = "RaporlarForm";
            this.Text = "RaporlarForm";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMusteri;
        private System.Windows.Forms.DataGridView dgRez;
        private System.Windows.Forms.Button button1;
    }
}