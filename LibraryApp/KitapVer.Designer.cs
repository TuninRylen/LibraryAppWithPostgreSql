namespace LibraryApp
{
    partial class KitapVer
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
            this.cbx_telefon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_kitap = new System.Windows.Forms.ComboBox();
            this.btn_kitapver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_telefon
            // 
            this.cbx_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_telefon.FormattingEnabled = true;
            this.cbx_telefon.Location = new System.Drawing.Point(57, 215);
            this.cbx_telefon.Name = "cbx_telefon";
            this.cbx_telefon.Size = new System.Drawing.Size(524, 39);
            this.cbx_telefon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefon Numarası Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(774, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap İsmi Ara";
            // 
            // cbx_kitap
            // 
            this.cbx_kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_kitap.FormattingEnabled = true;
            this.cbx_kitap.ItemHeight = 31;
            this.cbx_kitap.Items.AddRange(new object[] {
            "A",
            "B",
            "V",
            "D",
            "E",
            "E",
            "E",
            "E",
            "E",
            "E",
            "EE",
            "EE",
            "E",
            "E",
            "A",
            "B",
            "V",
            "D",
            "E",
            "E",
            "E",
            "E",
            "E",
            "E",
            "EE",
            "EE",
            "E",
            "E",
            "E",
            "E",
            "A",
            "B",
            "V",
            "D",
            "E",
            "E",
            "E",
            "E",
            "E",
            "E",
            "EE",
            "EE",
            "E",
            "E",
            "E",
            "E",
            "E",
            "E"});
            this.cbx_kitap.Location = new System.Drawing.Point(623, 215);
            this.cbx_kitap.Name = "cbx_kitap";
            this.cbx_kitap.Size = new System.Drawing.Size(524, 39);
            this.cbx_kitap.TabIndex = 2;
            // 
            // btn_kitapver
            // 
            this.btn_kitapver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapver.Location = new System.Drawing.Point(1184, 366);
            this.btn_kitapver.Name = "btn_kitapver";
            this.btn_kitapver.Size = new System.Drawing.Size(184, 93);
            this.btn_kitapver.TabIndex = 4;
            this.btn_kitapver.Text = "Kitabı Ver";
            this.btn_kitapver.UseVisualStyleBackColor = true;
            // 
            // KitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 760);
            this.Controls.Add(this.btn_kitapver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_kitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_telefon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KitapVer";
            this.Text = "KitapVer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_telefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_kitap;
        private System.Windows.Forms.Button btn_kitapver;
    }
}