
namespace doan
{
    partial class Index
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
            this.btndiachi = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnchinhanh = new System.Windows.Forms.Button();
            this.btnnpp = new System.Windows.Forms.Button();
            this.btnxe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndiachi
            // 
            this.btndiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiachi.Location = new System.Drawing.Point(46, 167);
            this.btndiachi.Name = "btndiachi";
            this.btndiachi.Size = new System.Drawing.Size(122, 33);
            this.btndiachi.TabIndex = 80;
            this.btndiachi.Text = "Địa Chỉ";
            this.btndiachi.UseVisualStyleBackColor = true;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.Location = new System.Drawing.Point(46, 206);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(122, 33);
            this.btnnhanvien.TabIndex = 79;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            // 
            // btnchinhanh
            // 
            this.btnchinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchinhanh.Location = new System.Drawing.Point(46, 128);
            this.btnchinhanh.Name = "btnchinhanh";
            this.btnchinhanh.Size = new System.Drawing.Size(122, 33);
            this.btnchinhanh.TabIndex = 78;
            this.btnchinhanh.Text = "Chi Nhánh";
            this.btnchinhanh.UseVisualStyleBackColor = true;
            // 
            // btnnpp
            // 
            this.btnnpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnpp.Location = new System.Drawing.Point(12, 85);
            this.btnnpp.Name = "btnnpp";
            this.btnnpp.Size = new System.Drawing.Size(156, 37);
            this.btnnpp.TabIndex = 77;
            this.btnnpp.Text = "Nhà Phân Phối";
            this.btnnpp.UseVisualStyleBackColor = true;
            // 
            // btnxe
            // 
            this.btnxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxe.Location = new System.Drawing.Point(46, 46);
            this.btnxe.Name = "btnxe";
            this.btnxe.Size = new System.Drawing.Size(122, 33);
            this.btnxe.TabIndex = 76;
            this.btnxe.Text = "Xe";
            this.btnxe.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndiachi);
            this.Controls.Add(this.btnnhanvien);
            this.Controls.Add(this.btnchinhanh);
            this.Controls.Add(this.btnnpp);
            this.Controls.Add(this.btnxe);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btndiachi;
        internal System.Windows.Forms.Button btnnhanvien;
        internal System.Windows.Forms.Button btnchinhanh;
        internal System.Windows.Forms.Button btnnpp;
        internal System.Windows.Forms.Button btnxe;
    }
}