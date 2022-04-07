
namespace doan
{
    partial class NhanVien
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
            this.txtCartNumber = new System.Windows.Forms.TextBox();
            this.lbluong = new System.Windows.Forms.Label();
            this.lbcmnd = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbtenduong = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lbfind = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.txttenNv = new System.Windows.Forms.TextBox();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.lbcn = new System.Windows.Forms.Label();
            this.lbxe = new System.Windows.Forms.Label();
            this.nud_salary = new System.Windows.Forms.NumericUpDown();
            this.cb_distributor = new System.Windows.Forms.ComboBox();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.cb_address = new System.Windows.Forms.ComboBox();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCartNumber
            // 
            this.txtCartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartNumber.Location = new System.Drawing.Point(170, 187);
            this.txtCartNumber.Name = "txtCartNumber";
            this.txtCartNumber.Size = new System.Drawing.Size(563, 30);
            this.txtCartNumber.TabIndex = 96;
            // 
            // lbluong
            // 
            this.lbluong.AutoSize = true;
            this.lbluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluong.Location = new System.Drawing.Point(82, 368);
            this.lbluong.Name = "lbluong";
            this.lbluong.Size = new System.Drawing.Size(67, 25);
            this.lbluong.TabIndex = 94;
            this.lbluong.Text = "Lương";
            // 
            // lbcmnd
            // 
            this.lbcmnd.AutoSize = true;
            this.lbcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcmnd.Location = new System.Drawing.Point(12, 191);
            this.lbcmnd.Name = "lbcmnd";
            this.lbcmnd.Size = new System.Drawing.Size(137, 25);
            this.lbcmnd.TabIndex = 93;
            this.lbcmnd.Text = "CMND/CCCD";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysinh.Location = new System.Drawing.Point(46, 131);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(103, 25);
            this.lbngaysinh.TabIndex = 92;
            this.lbngaysinh.Text = "Ngày Sinh";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(170, 424);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(563, 30);
            this.txttimkiem.TabIndex = 91;
            // 
            // lbtenduong
            // 
            this.lbtenduong.AutoSize = true;
            this.lbtenduong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenduong.Location = new System.Drawing.Point(5, 10);
            this.lbtenduong.Name = "lbtenduong";
            this.lbtenduong.Size = new System.Drawing.Size(144, 25);
            this.lbtenduong.TabIndex = 90;
            this.lbtenduong.Text = "Tên Nhân Viên";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdata.Location = new System.Drawing.Point(0, 479);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(958, 137);
            this.dgvdata.TabIndex = 89;
            this.dgvdata.Click += new System.EventHandler(this.dgvdata_Click);
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfind.Location = new System.Drawing.Point(54, 424);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(95, 25);
            this.lbfind.TabIndex = 88;
            this.lbfind.Text = "Tìm Kiếm";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.Location = new System.Drawing.Point(73, 72);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(76, 25);
            this.lbdiachi.TabIndex = 87;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // txttenNv
            // 
            this.txttenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenNv.Location = new System.Drawing.Point(170, 10);
            this.txttenNv.Name = "txttenNv";
            this.txttenNv.Size = new System.Drawing.Size(563, 30);
            this.txttenNv.TabIndex = 86;
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(801, 335);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(122, 36);
            this.btnreload.TabIndex = 84;
            this.btnreload.Text = "Tải lại";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(801, 387);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(122, 36);
            this.btnfind.TabIndex = 83;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnrep
            // 
            this.btnrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.Location = new System.Drawing.Point(801, 275);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(122, 36);
            this.btnrep.TabIndex = 82;
            this.btnrep.Text = "Sửa";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(801, 214);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(122, 36);
            this.btndel.TabIndex = 81;
            this.btndel.Text = "Xoá";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(801, 158);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 36);
            this.btnadd.TabIndex = 80;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Birthday
            // 
            this.Birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(171, 128);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(562, 30);
            this.Birthday.TabIndex = 98;
            // 
            // lbcn
            // 
            this.lbcn.AutoSize = true;
            this.lbcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcn.Location = new System.Drawing.Point(44, 250);
            this.lbcn.Name = "lbcn";
            this.lbcn.Size = new System.Drawing.Size(105, 25);
            this.lbcn.TabIndex = 100;
            this.lbcn.Text = "Chi Nhánh";
            // 
            // lbxe
            // 
            this.lbxe.AutoSize = true;
            this.lbxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxe.Location = new System.Drawing.Point(112, 309);
            this.lbxe.Name = "lbxe";
            this.lbxe.Size = new System.Drawing.Size(37, 25);
            this.lbxe.TabIndex = 102;
            this.lbxe.Text = "Xe";
            // 
            // nud_salary
            // 
            this.nud_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nud_salary.Location = new System.Drawing.Point(171, 368);
            this.nud_salary.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.nud_salary.Name = "nud_salary";
            this.nud_salary.Size = new System.Drawing.Size(562, 30);
            this.nud_salary.TabIndex = 103;
            // 
            // cb_distributor
            // 
            this.cb_distributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cb_distributor.FormattingEnabled = true;
            this.cb_distributor.Location = new System.Drawing.Point(170, 253);
            this.cb_distributor.Name = "cb_distributor";
            this.cb_distributor.Size = new System.Drawing.Size(563, 33);
            this.cb_distributor.TabIndex = 104;
            this.cb_distributor.SelectedIndexChanged += new System.EventHandler(this.cb_distributor_SelectedIndexChanged);
            // 
            // cb_car
            // 
            this.cb_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Location = new System.Drawing.Point(170, 309);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(563, 33);
            this.cb_car.TabIndex = 105;
            // 
            // cb_address
            // 
            this.cb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cb_address.FormattingEnabled = true;
            this.cb_address.Location = new System.Drawing.Point(171, 73);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(563, 33);
            this.cb_address.TabIndex = 106;
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(853, 13);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(93, 36);
            this.btn_home.TabIndex = 107;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 616);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.cb_address);
            this.Controls.Add(this.cb_car);
            this.Controls.Add(this.cb_distributor);
            this.Controls.Add(this.nud_salary);
            this.Controls.Add(this.lbxe);
            this.Controls.Add(this.lbcn);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.txtCartNumber);
            this.Controls.Add(this.lbluong);
            this.Controls.Add(this.lbcmnd);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.lbtenduong);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbfind);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.txttenNv);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtCartNumber;
        internal System.Windows.Forms.Label lbluong;
        internal System.Windows.Forms.Label lbcmnd;
        internal System.Windows.Forms.Label lbngaysinh;
        internal System.Windows.Forms.TextBox txttimkiem;
        internal System.Windows.Forms.Label lbtenduong;
        private System.Windows.Forms.DataGridView dgvdata;
        internal System.Windows.Forms.Label lbfind;
        internal System.Windows.Forms.Label lbdiachi;
        internal System.Windows.Forms.TextBox txttenNv;
        internal System.Windows.Forms.Button btnreload;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Button btnrep;
        internal System.Windows.Forms.Button btndel;
        internal System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker Birthday;
        internal System.Windows.Forms.Label lbcn;
        internal System.Windows.Forms.Label lbxe;
        private System.Windows.Forms.NumericUpDown nud_salary;
        private System.Windows.Forms.ComboBox cb_distributor;
        private System.Windows.Forms.ComboBox cb_car;
        private System.Windows.Forms.ComboBox cb_address;
        internal System.Windows.Forms.Button btn_home;
    }
}