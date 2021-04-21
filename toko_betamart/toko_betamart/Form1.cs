using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toko_betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tb_barang' table. You can move, or remove it, as needed.
            this.tb_barangTableAdapter.Fill(this.appData.tb_barang);
            tbbarangBindingSource.DataSource = this.appData.tb_barang;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    dataGridView.DataSource = tbbarangBindingSource;
                else
                {
                    var query = from o in this.appData.tb_barang
                                where o.NamaBarang.Contains(txtSearch.Text) || o.StokBarang == txtSearch.Text || o.HargaBarang == txtSearch.Text || o.AsalBarang.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("are you sure wamt to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tbbarangBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtNmBrg.Focus();
                this.appData.tb_barang.Addtb_barangRow(this.appData.tb_barang.Newtb_barangRow());
                tbbarangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbarangBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtNmBrg.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            tbbarangBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tbbarangBindingSource.EndEdit();
                tb_barangTableAdapter.Update(this.appData.tb_barang);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbarangBindingSource.ResetBindings(false);
            }
        }

        private void txtNmBrg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
