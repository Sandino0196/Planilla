using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void z_MemRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.z_MemRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._20181126DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_20181126DataSet.Z_MemRecord' Puede moverla o quitarla según sea necesario.
            this.z_MemRecordTableAdapter.Fill(this._20181126DataSet.Z_MemRecord);
        }

        private void z_MemRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
