namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this._20181126DataSet = new WindowsFormsApp1._20181126DataSet();
            this.z_MemRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.z_MemRecordTableAdapter = new WindowsFormsApp1._20181126DataSetTableAdapters.Z_MemRecordTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._20181126DataSetTableAdapters.TableAdapterManager();
            this.z_MemRecordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.z_MemRecordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.z_MemRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._20181126DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordBindingNavigator)).BeginInit();
            this.z_MemRecordBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _20181126DataSet
            // 
            this._20181126DataSet.DataSetName = "_20181126DataSet";
            this._20181126DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // z_MemRecordBindingSource
            // 
            this.z_MemRecordBindingSource.DataMember = "Z_MemRecord";
            this.z_MemRecordBindingSource.DataSource = this._20181126DataSet;
            // 
            // z_MemRecordTableAdapter
            // 
            this.z_MemRecordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessGroupTableAdapter = null;
            this.tableAdapterManager.AccessTimeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseParaTableAdapter = null;
            this.tableAdapterManager.CheckinoutTableAdapter = null;
            this.tableAdapterManager.CheckLogTableAdapter = null;
            this.tableAdapterManager.DefineFieldTableAdapter = null;
            this.tableAdapterManager.DeptTableAdapter = null;
            this.tableAdapterManager.DeviceGroupTableAdapter = null;
            this.tableAdapterManager.FingerClientTableAdapter = null;
            this.tableAdapterManager.HolidayTableAdapter = null;
            this.tableAdapterManager.LeaveClassTableAdapter = null;
            this.tableAdapterManager.MemStatTableAdapter = null;
            this.tableAdapterManager.OPClientTableAdapter = null;
            this.tableAdapterManager.OPDeptTableAdapter = null;
            this.tableAdapterManager.OPGroupTableAdapter = null;
            this.tableAdapterManager.OPinfoTableAdapter = null;
            this.tableAdapterManager.OPLogTableAdapter = null;
            this.tableAdapterManager.OutProgTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.SchTimeTableAdapter = null;
            this.tableAdapterManager.StatItemsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TimeTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._20181126DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAutoClassTableAdapter = null;
            this.tableAdapterManager.UserFingerTableAdapter = null;
            this.tableAdapterManager.UserinfoTableAdapter = null;
            this.tableAdapterManager.UserLeaveTableAdapter = null;
            this.tableAdapterManager.UserPowerTableAdapter = null;
            this.tableAdapterManager.UserShiftTableAdapter = null;
            this.tableAdapterManager.UserTempShiftTableAdapter = null;
            this.tableAdapterManager.WorkCodeTableAdapter = null;
            this.tableAdapterManager.Z_MemAbnorTableAdapter = null;
            this.tableAdapterManager.Z_MemRecordTableAdapter = this.z_MemRecordTableAdapter;
            this.tableAdapterManager.Z_MemUClassTableAdapter = null;
            // 
            // z_MemRecordBindingNavigator
            // 
            this.z_MemRecordBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.z_MemRecordBindingNavigator.BindingSource = this.z_MemRecordBindingSource;
            this.z_MemRecordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.z_MemRecordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.z_MemRecordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.z_MemRecordBindingNavigatorSaveItem});
            this.z_MemRecordBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.z_MemRecordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.z_MemRecordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.z_MemRecordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.z_MemRecordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.z_MemRecordBindingNavigator.Name = "z_MemRecordBindingNavigator";
            this.z_MemRecordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.z_MemRecordBindingNavigator.Size = new System.Drawing.Size(1301, 25);
            this.z_MemRecordBindingNavigator.TabIndex = 0;
            this.z_MemRecordBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // z_MemRecordBindingNavigatorSaveItem
            // 
            this.z_MemRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.z_MemRecordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("z_MemRecordBindingNavigatorSaveItem.Image")));
            this.z_MemRecordBindingNavigatorSaveItem.Name = "z_MemRecordBindingNavigatorSaveItem";
            this.z_MemRecordBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.z_MemRecordBindingNavigatorSaveItem.Text = "Guardar datos";
            this.z_MemRecordBindingNavigatorSaveItem.Click += new System.EventHandler(this.z_MemRecordBindingNavigatorSaveItem_Click);
            // 
            // z_MemRecordDataGridView
            // 
            this.z_MemRecordDataGridView.AutoGenerateColumns = false;
            this.z_MemRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.z_MemRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.z_MemRecordDataGridView.DataSource = this.z_MemRecordBindingSource;
            this.z_MemRecordDataGridView.Location = new System.Drawing.Point(12, 28);
            this.z_MemRecordDataGridView.Name = "z_MemRecordDataGridView";
            this.z_MemRecordDataGridView.Size = new System.Drawing.Size(1277, 418);
            this.z_MemRecordDataGridView.TabIndex = 1;
            this.z_MemRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.z_MemRecordDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Lsh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Lsh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "uid";
            this.dataGridViewTextBoxColumn2.HeaderText = "uid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ucode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ucode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Checktime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Checktime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Udept";
            this.dataGridViewTextBoxColumn5.HeaderText = "Udept";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Uname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Uname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Utype";
            this.dataGridViewTextBoxColumn7.HeaderText = "Utype";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Utypename";
            this.dataGridViewTextBoxColumn8.HeaderText = "Utypename";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sensorid";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sensorid";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Timename";
            this.dataGridViewTextBoxColumn10.HeaderText = "Timename";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Disposeplan";
            this.dataGridViewTextBoxColumn11.HeaderText = "Disposeplan";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Errorshow";
            this.dataGridViewTextBoxColumn12.HeaderText = "Errorshow";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Checked";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Checked";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UAttFlag";
            this.dataGridViewTextBoxColumn13.HeaderText = "UAttFlag";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UAttFlagName";
            this.dataGridViewTextBoxColumn14.HeaderText = "UAttFlagName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "UWorktype";
            this.dataGridViewTextBoxColumn15.HeaderText = "UWorktype";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ULogid";
            this.dataGridViewTextBoxColumn16.HeaderText = "ULogid";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 458);
            this.Controls.Add(this.z_MemRecordDataGridView);
            this.Controls.Add(this.z_MemRecordBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._20181126DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordBindingNavigator)).EndInit();
            this.z_MemRecordBindingNavigator.ResumeLayout(false);
            this.z_MemRecordBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_MemRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _20181126DataSet _20181126DataSet;
        private System.Windows.Forms.BindingSource z_MemRecordBindingSource;
        private _20181126DataSetTableAdapters.Z_MemRecordTableAdapter z_MemRecordTableAdapter;
        private _20181126DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator z_MemRecordBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton z_MemRecordBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView z_MemRecordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}