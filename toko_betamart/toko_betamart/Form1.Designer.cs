namespace toko_betamart
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new toko_betamart.AppData();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtAsalBrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHrgBrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokBrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNmBrg = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tb_barangTableAdapter = new toko_betamart.AppDataTableAdapters.tb_barangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.stokBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn,
            this.asalBarangDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tbbarangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 279);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(464, 163);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // stokBarangDataGridViewTextBoxColumn
            // 
            this.stokBarangDataGridViewTextBoxColumn.DataPropertyName = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.HeaderText = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.Name = "stokBarangDataGridViewTextBoxColumn";
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            // 
            // asalBarangDataGridViewTextBoxColumn
            // 
            this.asalBarangDataGridViewTextBoxColumn.DataPropertyName = "AsalBarang";
            this.asalBarangDataGridViewTextBoxColumn.HeaderText = "AsalBarang";
            this.asalBarangDataGridViewTextBoxColumn.Name = "asalBarangDataGridViewTextBoxColumn";
            this.asalBarangDataGridViewTextBoxColumn.Width = 200;
            // 
            // tbbarangBindingSource
            // 
            this.tbbarangBindingSource.DataMember = "tb_barang";
            this.tbbarangBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Barang :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtAsalBrg);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtHrgBrg);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtStokBrg);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtNmBrg);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(15, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(464, 234);
            this.panel.TabIndex = 2;
            // 
            // txtAsalBrg
            // 
            this.txtAsalBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "AsalBarang", true));
            this.txtAsalBrg.Location = new System.Drawing.Point(132, 136);
            this.txtAsalBrg.Multiline = true;
            this.txtAsalBrg.Name = "txtAsalBrg";
            this.txtAsalBrg.Size = new System.Drawing.Size(304, 62);
            this.txtAsalBrg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Asal Barang :";
            // 
            // txtHrgBrg
            // 
            this.txtHrgBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "HargaBarang", true));
            this.txtHrgBrg.Location = new System.Drawing.Point(132, 99);
            this.txtHrgBrg.Name = "txtHrgBrg";
            this.txtHrgBrg.Size = new System.Drawing.Size(234, 20);
            this.txtHrgBrg.TabIndex = 2;
            this.txtHrgBrg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang  :";
            // 
            // txtStokBrg
            // 
            this.txtStokBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "StokBarang", true));
            this.txtStokBrg.Location = new System.Drawing.Point(132, 64);
            this.txtStokBrg.Name = "txtStokBrg";
            this.txtStokBrg.Size = new System.Drawing.Size(234, 20);
            this.txtStokBrg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Barang  :";
            // 
            // txtNmBrg
            // 
            this.txtNmBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "NamaBarang", true));
            this.txtNmBrg.Location = new System.Drawing.Point(132, 28);
            this.txtNmBrg.Name = "txtNmBrg";
            this.txtNmBrg.Size = new System.Drawing.Size(234, 20);
            this.txtNmBrg.TabIndex = 0;
            this.txtNmBrg.TextChanged += new System.EventHandler(this.txtNmBrg_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(85, 253);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search :";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 451);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(142, 451);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tb_barangTableAdapter
            // 
            this.tb_barangTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 484);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtNmBrg;
        private System.Windows.Forms.TextBox txtAsalBrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHrgBrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokBrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbbarangBindingSource;
        private AppDataTableAdapters.tb_barangTableAdapter tb_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalBarangDataGridViewTextBoxColumn;
    }
}

