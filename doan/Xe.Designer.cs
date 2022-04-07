
namespace doan
{
    partial class Xe
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lbfind = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbnpp = new System.Windows.Forms.Label();
            this.lbchinhanh = new System.Windows.Forms.Label();
            this.lbxe = new System.Windows.Forms.Label();
            this.txttenxe = new System.Windows.Forms.TextBox();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.lbnhanvien = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbmau = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cb_distributor = new System.Windows.Forms.ComboBox();
            this.txtnamsx = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamsx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdata.Location = new System.Drawing.Point(0, 424);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(976, 150);
            this.dgvdata.TabIndex = 47;
            this.dgvdata.Click += new System.EventHandler(this.dgvdata_Click);
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfind.Location = new System.Drawing.Point(81, 368);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(95, 25);
            this.lbfind.TabIndex = 46;
            this.lbfind.Text = "Tìm Kiếm";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.Location = new System.Drawing.Point(33, 191);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(143, 25);
            this.lbdiachi.TabIndex = 45;
            this.lbdiachi.Text = "Nhà Phân Phối";
            // 
            // lbnpp
            // 
            this.lbnpp.AutoSize = true;
            this.lbnpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnpp.Location = new System.Drawing.Point(79, 73);
            this.lbnpp.Name = "lbnpp";
            this.lbnpp.Size = new System.Drawing.Size(97, 25);
            this.lbnpp.TabIndex = 44;
            this.lbnpp.Text = "Số Lượng";
            // 
            // lbchinhanh
            // 
            this.lbchinhanh.AutoSize = true;
            this.lbchinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchinhanh.Location = new System.Drawing.Point(66, 132);
            this.lbchinhanh.Name = "lbchinhanh";
            this.lbchinhanh.Size = new System.Drawing.Size(110, 25);
            this.lbchinhanh.TabIndex = 43;
            this.lbchinhanh.Text = "Ngày Nhập";
            // 
            // lbxe
            // 
            this.lbxe.AutoSize = true;
            this.lbxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxe.Location = new System.Drawing.Point(99, 14);
            this.lbxe.Name = "lbxe";
            this.lbxe.Size = new System.Drawing.Size(77, 25);
            this.lbxe.TabIndex = 42;
            this.lbxe.Text = "Tên Xe";
            // 
            // txttenxe
            // 
            this.txttenxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenxe.Location = new System.Drawing.Point(182, 14);
            this.txttenxe.Name = "txttenxe";
            this.txttenxe.Size = new System.Drawing.Size(563, 30);
            this.txttenxe.TabIndex = 41;
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(813, 276);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(122, 33);
            this.btnreload.TabIndex = 36;
            this.btnreload.Text = "Tải lại";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(813, 360);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(122, 33);
            this.btnfind.TabIndex = 35;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnrep
            // 
            this.btnrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.Location = new System.Drawing.Point(813, 188);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(122, 33);
            this.btnrep.TabIndex = 34;
            this.btnrep.Text = "Sửa";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(813, 100);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(122, 33);
            this.btndel.TabIndex = 33;
            this.btndel.Text = "Xoá";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(813, 14);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 33);
            this.btnadd.TabIndex = 32;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtmau
            // 
            this.txtmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmau.Location = new System.Drawing.Point(182, 309);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(563, 30);
            this.txtmau.TabIndex = 48;
            // 
            // lbnhanvien
            // 
            this.lbnhanvien.AutoSize = true;
            this.lbnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhanvien.Location = new System.Drawing.Point(36, 250);
            this.lbnhanvien.Name = "lbnhanvien";
            this.lbnhanvien.Size = new System.Drawing.Size(140, 25);
            this.lbnhanvien.TabIndex = 49;
            this.lbnhanvien.Text = "Năm Sản Xuất";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(182, 370);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(563, 30);
            this.txttimkiem.TabIndex = 50;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // lbmau
            // 
            this.lbmau.AutoSize = true;
            this.lbmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmau.Location = new System.Drawing.Point(95, 309);
            this.lbmau.Name = "lbmau";
            this.lbmau.Size = new System.Drawing.Size(81, 25);
            this.lbmau.TabIndex = 51;
            this.lbmau.Text = "Màu Xe";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(182, 73);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(563, 30);
            this.txtamount.TabIndex = 53;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(182, 130);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(562, 30);
            this.date.TabIndex = 54;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // cb_distributor
            // 
            this.cb_distributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cb_distributor.FormattingEnabled = true;
            this.cb_distributor.Location = new System.Drawing.Point(181, 191);
            this.cb_distributor.Name = "cb_distributor";
            this.cb_distributor.Size = new System.Drawing.Size(563, 33);
            this.cb_distributor.TabIndex = 55;
            // 
            // txtnamsx
            // 
            this.txtnamsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamsx.Location = new System.Drawing.Point(182, 248);
            this.txtnamsx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtnamsx.Name = "txtnamsx";
            this.txtnamsx.Size = new System.Drawing.Size(563, 30);
            this.txtnamsx.TabIndex = 56;
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 574);
            this.Controls.Add(this.txtnamsx);
            this.Controls.Add(this.cb_distributor);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lbmau);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.lbnhanvien);
            this.Controls.Add(this.txtmau);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbfind);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbnpp);
            this.Controls.Add(this.lbchinhanh);
            this.Controls.Add(this.lbxe);
            this.Controls.Add(this.txttenxe);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Name = "Xe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        internal System.Windows.Forms.Label lbfind;
        internal System.Windows.Forms.Label lbdiachi;
        internal System.Windows.Forms.Label lbnpp;
        internal System.Windows.Forms.Label lbchinhanh;
        internal System.Windows.Forms.Label lbxe;
        internal System.Windows.Forms.TextBox txttenxe;
        internal System.Windows.Forms.Button btnreload;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Button btnrep;
        internal System.Windows.Forms.Button btndel;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.TextBox txtmau;
        internal System.Windows.Forms.Label lbnhanvien;
        internal System.Windows.Forms.TextBox txttimkiem;
        internal System.Windows.Forms.Label lbmau;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cb_distributor;
        private System.Windows.Forms.NumericUpDown txtnamsx;
    }
}

