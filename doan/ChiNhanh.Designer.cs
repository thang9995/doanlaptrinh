﻿
namespace doan
{
    partial class ChiNhanh
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lbfind = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbnpp = new System.Windows.Forms.Label();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(226, 294);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(563, 30);
            this.txttimkiem.TabIndex = 84;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdata.Location = new System.Drawing.Point(0, 404);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(983, 150);
            this.dgvdata.TabIndex = 83;
            this.dgvdata.Click += new System.EventHandler(this.dgvdata_Click);
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfind.Location = new System.Drawing.Point(106, 294);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(95, 25);
            this.lbfind.TabIndex = 82;
            this.lbfind.Text = "Tìm Kiếm";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(56, 69);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(145, 25);
            this.lbten.TabIndex = 81;
            this.lbten.Text = "Tên Chi Nhánh";
            // 
            // lbnpp
            // 
            this.lbnpp.AutoSize = true;
            this.lbnpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnpp.Location = new System.Drawing.Point(125, 183);
            this.lbnpp.Name = "lbnpp";
            this.lbnpp.Size = new System.Drawing.Size(76, 25);
            this.lbnpp.TabIndex = 80;
            this.lbnpp.Text = "Địa Chỉ";
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(226, 69);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(563, 30);
            this.txtcn.TabIndex = 77;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(226, 183);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(563, 30);
            this.txtdiachi.TabIndex = 76;
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(832, 259);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(122, 33);
            this.btnreload.TabIndex = 75;
            this.btnreload.Text = "Tải lại";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(832, 335);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(122, 33);
            this.btnfind.TabIndex = 74;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnrep
            // 
            this.btnrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.Location = new System.Drawing.Point(832, 183);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(122, 33);
            this.btnrep.TabIndex = 73;
            this.btnrep.Text = "Sửa";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(832, 107);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(122, 33);
            this.btndel.TabIndex = 72;
            this.btndel.Text = "Xoá";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(832, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 33);
            this.btnadd.TabIndex = 71;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbfind);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbnpp);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Name = "ChiNhanh";
            this.Text = "Chi Nhánh";
            this.Load += new System.EventHandler(this.ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dgvdata;
        internal System.Windows.Forms.Label lbfind;
        internal System.Windows.Forms.Label lbten;
        internal System.Windows.Forms.Label lbnpp;
        internal System.Windows.Forms.TextBox txtcn;
        internal System.Windows.Forms.TextBox txtdiachi;
        internal System.Windows.Forms.Button btnreload;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Button btnrep;
        internal System.Windows.Forms.Button btndel;
        internal System.Windows.Forms.Button btnadd;
    }
}