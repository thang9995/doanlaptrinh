
namespace doan
{
    partial class Login
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
            this.lbid = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(45, 175);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(151, 25);
            this.lbid.TabIndex = 85;
            this.lbid.Text = "Tên Đăng Nhập";
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.Location = new System.Drawing.Point(99, 253);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(97, 25);
            this.lbmk.TabIndex = 84;
            this.lbmk.Text = "Mật Khẩu";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(242, 170);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(361, 30);
            this.tb_name.TabIndex = 83;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(242, 248);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(361, 30);
            this.tb_pass.TabIndex = 82;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(242, 327);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(229, 70);
            this.btnlogin.TabIndex = 86;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbtaikhoan.Location = new System.Drawing.Point(231, 49);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(290, 63);
            this.lbtaikhoan.TabIndex = 88;
            this.lbtaikhoan.Text = "Đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.lbtaikhoan);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_pass);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbid;
        internal System.Windows.Forms.Label lbmk;
        internal System.Windows.Forms.TextBox tb_name;
        internal System.Windows.Forms.TextBox tb_pass;
        internal System.Windows.Forms.Button btnlogin;
        internal System.Windows.Forms.Label lbtaikhoan;
    }
}