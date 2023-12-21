namespace LibraryApp
{
    partial class LoginForm
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
            this.btn_uye = new System.Windows.Forms.Button();
            this.btn_personel = new System.Windows.Forms.Button();
            this.btn_mudur = new System.Windows.Forms.Button();
            this.tbx_KutuphaneAd = new System.Windows.Forms.TextBox();
            this.btn_bagis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_uye
            // 
            this.btn_uye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uye.Location = new System.Drawing.Point(249, 436);
            this.btn_uye.Name = "btn_uye";
            this.btn_uye.Size = new System.Drawing.Size(189, 85);
            this.btn_uye.TabIndex = 0;
            this.btn_uye.Text = "Üye Girişi İçin Tıklatınız";
            this.btn_uye.UseVisualStyleBackColor = true;
            // 
            // btn_personel
            // 
            this.btn_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel.Location = new System.Drawing.Point(595, 436);
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.Size = new System.Drawing.Size(189, 85);
            this.btn_personel.TabIndex = 1;
            this.btn_personel.Text = "Personel Girişi İçin Tıklayınız";
            this.btn_personel.UseVisualStyleBackColor = true;
            // 
            // btn_mudur
            // 
            this.btn_mudur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mudur.Location = new System.Drawing.Point(928, 436);
            this.btn_mudur.Name = "btn_mudur";
            this.btn_mudur.Size = new System.Drawing.Size(189, 85);
            this.btn_mudur.TabIndex = 2;
            this.btn_mudur.Text = "Müdür Girişi İçin Tıklayınız";
            this.btn_mudur.UseVisualStyleBackColor = true;
            // 
            // tbx_KutuphaneAd
            // 
            this.tbx_KutuphaneAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_KutuphaneAd.Location = new System.Drawing.Point(379, 108);
            this.tbx_KutuphaneAd.Multiline = true;
            this.tbx_KutuphaneAd.Name = "tbx_KutuphaneAd";
            this.tbx_KutuphaneAd.ReadOnly = true;
            this.tbx_KutuphaneAd.Size = new System.Drawing.Size(621, 45);
            this.tbx_KutuphaneAd.TabIndex = 3;
            this.tbx_KutuphaneAd.Text = "HELLO";
            this.tbx_KutuphaneAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_bagis
            // 
            this.btn_bagis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bagis.Location = new System.Drawing.Point(1179, 702);
            this.btn_bagis.Name = "btn_bagis";
            this.btn_bagis.Size = new System.Drawing.Size(189, 46);
            this.btn_bagis.TabIndex = 4;
            this.btn_bagis.Text = "Bağışda Bulun";
            this.btn_bagis.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 760);
            this.Controls.Add(this.btn_bagis);
            this.Controls.Add(this.tbx_KutuphaneAd);
            this.Controls.Add(this.btn_mudur);
            this.Controls.Add(this.btn_personel);
            this.Controls.Add(this.btn_uye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_uye;
        private System.Windows.Forms.Button btn_personel;
        private System.Windows.Forms.Button btn_mudur;
        private System.Windows.Forms.TextBox tbx_KutuphaneAd;
        private System.Windows.Forms.Button btn_bagis;
    }
}

