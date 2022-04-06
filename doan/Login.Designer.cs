
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
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
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
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(242, 170);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(361, 30);
            this.txtcn.TabIndex = 83;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(242, 248);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(361, 30);
            this.txtdiachi.TabIndex = 82;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(302, 313);
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
            this.lbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaikhoan.Location = new System.Drawing.Point(226, 9);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(399, 91);
            this.lbtaikhoan.TabIndex = 88;
            this.lbtaikhoan.Text = "Tài Khoản";
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
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtdiachi);
            this.Name = "Login";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbid;
        internal System.Windows.Forms.Label lbmk;
        internal System.Windows.Forms.TextBox txtcn;
        internal System.Windows.Forms.TextBox txtdiachi;
        internal System.Windows.Forms.Button btnlogin;
        internal System.Windows.Forms.Label lbtaikhoan;
    }
}