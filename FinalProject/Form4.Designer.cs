namespace FinalProject
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lbl_Kode = new System.Windows.Forms.Label();
            this.lbl_NmBrg = new System.Windows.Forms.Label();
            this.lbl_Stok = new System.Windows.Forms.Label();
            this.lbl_Hrg = new System.Windows.Forms.Label();
            this.tbx_IdBrg = new System.Windows.Forms.TextBox();
            this.tbx_NmBrg = new System.Windows.Forms.TextBox();
            this.tbx_Stok = new System.Windows.Forms.TextBox();
            this.tbx_Hrg = new System.Windows.Forms.TextBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparepartBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirPABDDataSet1 = new FinalProject.TugasAkhirPABDDataSet();
            this.sparepartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sparepartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparepartTableAdapter2 = new FinalProject.TugasAkhirPABDDataSetTableAdapters.sparepartTableAdapter();
            this.tugasAkhirPABDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirPABDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirPABDDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Kode
            // 
            this.lbl_Kode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Kode.AutoSize = true;
            this.lbl_Kode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Kode.Font = new System.Drawing.Font("Swis721 Hv BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kode.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_Kode.Location = new System.Drawing.Point(35, 88);
            this.lbl_Kode.Name = "lbl_Kode";
            this.lbl_Kode.Size = new System.Drawing.Size(98, 16);
            this.lbl_Kode.TabIndex = 1;
            this.lbl_Kode.Text = "Kode Barang";
            this.lbl_Kode.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // lbl_NmBrg
            // 
            this.lbl_NmBrg.AutoSize = true;
            this.lbl_NmBrg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_NmBrg.Font = new System.Drawing.Font("Swis721 Hv BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NmBrg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_NmBrg.Location = new System.Drawing.Point(31, 140);
            this.lbl_NmBrg.Name = "lbl_NmBrg";
            this.lbl_NmBrg.Size = new System.Drawing.Size(102, 16);
            this.lbl_NmBrg.TabIndex = 2;
            this.lbl_NmBrg.Text = "Nama Barang";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.AutoSize = true;
            this.lbl_Stok.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stok.Font = new System.Drawing.Font("Swis721 Hv BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_Stok.Location = new System.Drawing.Point(35, 187);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(40, 16);
            this.lbl_Stok.TabIndex = 3;
            this.lbl_Stok.Text = "Stok";
            // 
            // lbl_Hrg
            // 
            this.lbl_Hrg.AutoSize = true;
            this.lbl_Hrg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Hrg.Font = new System.Drawing.Font("Swis721 Hv BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hrg.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_Hrg.Location = new System.Drawing.Point(35, 234);
            this.lbl_Hrg.Name = "lbl_Hrg";
            this.lbl_Hrg.Size = new System.Drawing.Size(50, 16);
            this.lbl_Hrg.TabIndex = 4;
            this.lbl_Hrg.Text = "Harga";
            // 
            // tbx_IdBrg
            // 
            this.tbx_IdBrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_IdBrg.Location = new System.Drawing.Point(145, 85);
            this.tbx_IdBrg.Multiline = true;
            this.tbx_IdBrg.Name = "tbx_IdBrg";
            this.tbx_IdBrg.Size = new System.Drawing.Size(204, 27);
            this.tbx_IdBrg.TabIndex = 5;
            this.tbx_IdBrg.TextChanged += new System.EventHandler(this.tbx_IdBrg_TextChanged);
            // 
            // tbx_NmBrg
            // 
            this.tbx_NmBrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_NmBrg.Location = new System.Drawing.Point(145, 137);
            this.tbx_NmBrg.Multiline = true;
            this.tbx_NmBrg.Name = "tbx_NmBrg";
            this.tbx_NmBrg.Size = new System.Drawing.Size(204, 27);
            this.tbx_NmBrg.TabIndex = 6;
            this.tbx_NmBrg.TextChanged += new System.EventHandler(this.tbx_NmBrg_TextChanged);
            // 
            // tbx_Stok
            // 
            this.tbx_Stok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_Stok.Location = new System.Drawing.Point(145, 184);
            this.tbx_Stok.Multiline = true;
            this.tbx_Stok.Name = "tbx_Stok";
            this.tbx_Stok.Size = new System.Drawing.Size(204, 27);
            this.tbx_Stok.TabIndex = 7;
            this.tbx_Stok.TextChanged += new System.EventHandler(this.tbx_Stok_TextChanged);
            // 
            // tbx_Hrg
            // 
            this.tbx_Hrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_Hrg.Location = new System.Drawing.Point(145, 231);
            this.tbx_Hrg.Multiline = true;
            this.tbx_Hrg.Name = "tbx_Hrg";
            this.tbx_Hrg.Size = new System.Drawing.Size(204, 27);
            this.tbx_Hrg.TabIndex = 8;
            this.tbx_Hrg.TextChanged += new System.EventHandler(this.tbx_Hrg_TextChanged);
            // 
            // btnUP
            // 
            this.btnUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUP.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUP.Font = new System.Drawing.Font("Swis721 Hv BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.Location = new System.Drawing.Point(720, 340);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(91, 37);
            this.btnUP.TabIndex = 9;
            this.btnUP.Text = "UPDATE";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDELETE.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDELETE.Font = new System.Drawing.Font("Swis721 Hv BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(720, 436);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(91, 37);
            this.btnDELETE.TabIndex = 11;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_Kode);
            this.panel2.Controls.Add(this.lbl_NmBrg);
            this.panel2.Controls.Add(this.lbl_Stok);
            this.panel2.Controls.Add(this.lbl_Hrg);
            this.panel2.Controls.Add(this.tbx_Hrg);
            this.panel2.Controls.Add(this.tbx_IdBrg);
            this.panel2.Controls.Add(this.tbx_Stok);
            this.panel2.Controls.Add(this.tbx_NmBrg);
            this.panel2.Location = new System.Drawing.Point(221, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 280);
            this.panel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodebarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sparepartBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(130, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 211);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            this.kodebarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sparepartBindingSource2
            // 
            this.sparepartBindingSource2.DataMember = "sparepart";
            this.sparepartBindingSource2.DataSource = this.tugasAkhirPABDDataSet1;
            // 
            // tugasAkhirPABDDataSet1
            // 
            this.tugasAkhirPABDDataSet1.DataSetName = "TugasAkhirPABDDataSet1";
            this.tugasAkhirPABDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparepartBindingSource
            // 
            this.sparepartBindingSource.DataMember = "sparepart";
            // 
            // sparepartTableAdapter2
            // 
            this.sparepartTableAdapter2.ClearBeforeFill = true;
            // 
            // tugasAkhirPABDDataSet1BindingSource
            // 
            this.tugasAkhirPABDDataSet1BindingSource.DataSource = this.tugasAkhirPABDDataSet1;
            this.tugasAkhirPABDDataSet1BindingSource.Position = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.BackColor = System.Drawing.Color.Red;
            this.btn_Back.Font = new System.Drawing.Font("Swis721 Hv BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(44, 476);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 33);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(981, 559);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.panel2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirPABDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirPABDDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Kode;
        private System.Windows.Forms.Label lbl_NmBrg;
        private System.Windows.Forms.Label lbl_Stok;
        private System.Windows.Forms.Label lbl_Hrg;
        private System.Windows.Forms.TextBox tbx_IdBrg;
        private System.Windows.Forms.TextBox tbx_NmBrg;
        private System.Windows.Forms.TextBox tbx_Stok;
        private System.Windows.Forms.TextBox tbx_Hrg;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sparepartBindingSource;
        private System.Windows.Forms.BindingSource sparepartBindingSource1;
        private TugasAkhirPABDDataSet tugasAkhirPABDDataSet1;
        private System.Windows.Forms.BindingSource sparepartBindingSource2;
        private TugasAkhirPABDDataSetTableAdapters.sparepartTableAdapter sparepartTableAdapter2;
        private System.Windows.Forms.BindingSource tugasAkhirPABDDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Back;
    }
}