namespace PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            xeMayBindingSource = new BindingSource(components);
            dgvNoiDung = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)xeMayBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).BeginInit();
            SuspendLayout();
            // 
            // xeMayBindingSource
            // 
            xeMayBindingSource.DataSource = typeof(DAL.Models.XeMay);
            // 
            // dgvNoiDung
            // 
            dgvNoiDung.AutoGenerateColumns = false;
            dgvNoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoiDung.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, STT, tenDataGridViewTextBoxColumn, motaDataGridViewTextBoxColumn, giaNhapDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn });
            dgvNoiDung.DataSource = xeMayBindingSource;
            dgvNoiDung.Location = new Point(12, 64);
            dgvNoiDung.Name = "dgvNoiDung";
            dgvNoiDung.RowTemplate.Height = 25;
            dgvNoiDung.Size = new Size(536, 141);
            dgvNoiDung.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // STT
            // 
            STT.DataPropertyName = "Id";
            STT.HeaderText = "STT";
            STT.Name = "STT";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Tên xe";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            motaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 217);
            Controls.Add(dgvNoiDung);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)xeMayBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource xeMayBindingSource;
        private DataGridView dgvNoiDung;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
    }
}