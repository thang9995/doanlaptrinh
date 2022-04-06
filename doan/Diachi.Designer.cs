
namespace doan
{
    partial class Diachi
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbtenduong = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lbfind = new System.Windows.Forms.Label();
            this.lbsonha = new System.Windows.Forms.Label();
            this.txttenduong = new System.Windows.Forms.TextBox();
            this.txtsonha = new System.Windows.Forms.TextBox();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbphuong = new System.Windows.Forms.Label();
            this.lbquan = new System.Windows.Forms.Label();
            this.lbtp = new System.Windows.Forms.Label();
            this.txtphuong = new System.Windows.Forms.TextBox();
            this.txtquanhuyen = new System.Windows.Forms.TextBox();
            this.txttp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(179, 313);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(563, 30);
            this.txttimkiem.TabIndex = 70;
            // 
            // lbtenduong
            // 
            this.lbtenduong.AutoSize = true;
            this.lbtenduong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenduong.Location = new System.Drawing.Point(47, 93);
            this.lbtenduong.Name = "lbtenduong";
            this.lbtenduong.Size = new System.Drawing.Size(110, 25);
            this.lbtenduong.TabIndex = 69;
            this.lbtenduong.Text = "Tên Đường";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdata.Location = new System.Drawing.Point(0, 412);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(977, 150);
            this.dgvdata.TabIndex = 67;
            this.dgvdata.Click += new System.EventHandler(this.dgvdata_Click);
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfind.Location = new System.Drawing.Point(62, 313);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(95, 25);
            this.lbfind.TabIndex = 66;
            this.lbfind.Text = "Tìm Kiếm";
            // 
            // lbsonha
            // 
            this.lbsonha.AutoSize = true;
            this.lbsonha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsonha.Location = new System.Drawing.Point(79, 38);
            this.lbsonha.Name = "lbsonha";
            this.lbsonha.Size = new System.Drawing.Size(78, 25);
            this.lbsonha.TabIndex = 65;
            this.lbsonha.Text = "Số Nhà";
            // 
            // txttenduong
            // 
            this.txttenduong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenduong.Location = new System.Drawing.Point(179, 96);
            this.txttenduong.Name = "txttenduong";
            this.txttenduong.Size = new System.Drawing.Size(563, 30);
            this.txttenduong.TabIndex = 60;
            // 
            // txtsonha
            // 
            this.txtsonha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsonha.Location = new System.Drawing.Point(179, 38);
            this.txtsonha.Name = "txtsonha";
            this.txtsonha.Size = new System.Drawing.Size(563, 30);
            this.txtsonha.TabIndex = 59;
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(810, 269);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(122, 33);
            this.btnreload.TabIndex = 56;
            this.btnreload.Text = "Tải lại";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(810, 353);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(122, 33);
            this.btnfind.TabIndex = 55;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnrep
            // 
            this.btnrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.Location = new System.Drawing.Point(810, 181);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(122, 33);
            this.btnrep.TabIndex = 54;
            this.btnrep.Text = "Sửa";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(810, 93);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(122, 33);
            this.btndel.TabIndex = 53;
            this.btndel.Text = "Xoá";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(810, 7);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 33);
            this.btnadd.TabIndex = 52;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbphuong
            // 
            this.lbphuong.AutoSize = true;
            this.lbphuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphuong.Location = new System.Drawing.Point(77, 148);
            this.lbphuong.Name = "lbphuong";
            this.lbphuong.Size = new System.Drawing.Size(80, 25);
            this.lbphuong.TabIndex = 72;
            this.lbphuong.Text = "Phường";
            // 
            // lbquan
            // 
            this.lbquan.AutoSize = true;
            this.lbquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquan.Location = new System.Drawing.Point(34, 203);
            this.lbquan.Name = "lbquan";
            this.lbquan.Size = new System.Drawing.Size(123, 25);
            this.lbquan.TabIndex = 73;
            this.lbquan.Text = "Quận,Huyện";
            // 
            // lbtp
            // 
            this.lbtp.AutoSize = true;
            this.lbtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtp.Location = new System.Drawing.Point(48, 258);
            this.lbtp.Name = "lbtp";
            this.lbtp.Size = new System.Drawing.Size(109, 25);
            this.lbtp.TabIndex = 74;
            this.lbtp.Text = "Thành Phố";
            // 
            // txtphuong
            // 
            this.txtphuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphuong.Location = new System.Drawing.Point(179, 148);
            this.txtphuong.Name = "txtphuong";
            this.txtphuong.Size = new System.Drawing.Size(563, 30);
            this.txtphuong.TabIndex = 77;
            // 
            // txtquanhuyen
            // 
            this.txtquanhuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquanhuyen.Location = new System.Drawing.Point(179, 203);
            this.txtquanhuyen.Name = "txtquanhuyen";
            this.txtquanhuyen.Size = new System.Drawing.Size(563, 30);
            this.txtquanhuyen.TabIndex = 78;
            // 
            // txttp
            // 
            this.txttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp.Location = new System.Drawing.Point(179, 258);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(563, 30);
            this.txttp.TabIndex = 79;
            // 
            // Diachi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 562);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtquanhuyen);
            this.Controls.Add(this.txtphuong);
            this.Controls.Add(this.lbtp);
            this.Controls.Add(this.lbquan);
            this.Controls.Add(this.lbphuong);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.lbtenduong);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbfind);
            this.Controls.Add(this.lbsonha);
            this.Controls.Add(this.txttenduong);
            this.Controls.Add(this.txtsonha);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Name = "Diachi";
            this.Text = "Diachi";
            this.Load += new System.EventHandler(this.Diachi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txttimkiem;
        internal System.Windows.Forms.Label lbtenduong;
        private System.Windows.Forms.DataGridView dgvdata;
        internal System.Windows.Forms.Label lbfind;
        internal System.Windows.Forms.Label lbsonha;
        internal System.Windows.Forms.TextBox txttenduong;
        internal System.Windows.Forms.TextBox txtsonha;
        internal System.Windows.Forms.Button btnreload;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Button btnrep;
        internal System.Windows.Forms.Button btndel;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label lbphuong;
        internal System.Windows.Forms.Label lbquan;
        internal System.Windows.Forms.Label lbtp;
        internal System.Windows.Forms.TextBox txtphuong;
        internal System.Windows.Forms.TextBox txtquanhuyen;
        internal System.Windows.Forms.TextBox txttp;
    }
}