namespace LibraryApp
{
    partial class KitapListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbx_ara = new System.Windows.Forms.TextBox();
            this.rdb_yazar = new System.Windows.Forms.RadioButton();
            this.rdb_isim = new System.Windows.Forms.RadioButton();
            this.rdb_ISBN = new System.Windows.Forms.RadioButton();
            this.btn_ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbx_ara
            // 
            this.tbx_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_ara.Location = new System.Drawing.Point(266, 91);
            this.tbx_ara.Multiline = true;
            this.tbx_ara.Name = "tbx_ara";
            this.tbx_ara.Size = new System.Drawing.Size(819, 85);
            this.tbx_ara.TabIndex = 1;
            this.tbx_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_yazar
            // 
            this.rdb_yazar.AutoSize = true;
            this.rdb_yazar.Location = new System.Drawing.Point(88, 95);
            this.rdb_yazar.Name = "rdb_yazar";
            this.rdb_yazar.Size = new System.Drawing.Size(134, 22);
            this.rdb_yazar.TabIndex = 2;
            this.rdb_yazar.TabStop = true;
            this.rdb_yazar.Text = "Yazara göre ara";
            this.rdb_yazar.UseVisualStyleBackColor = true;
            // 
            // rdb_isim
            // 
            this.rdb_isim.AutoSize = true;
            this.rdb_isim.Location = new System.Drawing.Point(88, 123);
            this.rdb_isim.Name = "rdb_isim";
            this.rdb_isim.Size = new System.Drawing.Size(120, 22);
            this.rdb_isim.TabIndex = 3;
            this.rdb_isim.TabStop = true;
            this.rdb_isim.Text = "İsme göre ara";
            this.rdb_isim.UseVisualStyleBackColor = true;
            // 
            // rdb_ISBN
            // 
            this.rdb_ISBN.AutoSize = true;
            this.rdb_ISBN.Location = new System.Drawing.Point(88, 151);
            this.rdb_ISBN.Name = "rdb_ISBN";
            this.rdb_ISBN.Size = new System.Drawing.Size(133, 22);
            this.rdb_ISBN.TabIndex = 4;
            this.rdb_ISBN.TabStop = true;
            this.rdb_ISBN.Text = "ISBN\'e göre ara";
            this.rdb_ISBN.UseVisualStyleBackColor = true;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(1145, 92);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(130, 84);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // KitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 760);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.rdb_ISBN);
            this.Controls.Add(this.rdb_isim);
            this.Controls.Add(this.rdb_yazar);
            this.Controls.Add(this.tbx_ara);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KitapListele";
            this.Text = "KitapListele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbx_ara;
        private System.Windows.Forms.RadioButton rdb_yazar;
        private System.Windows.Forms.RadioButton rdb_isim;
        private System.Windows.Forms.RadioButton rdb_ISBN;
        private System.Windows.Forms.Button btn_ara;
    }
}