
namespace PracticZadacha
{
    partial class dopyskygi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dopyskygi));
            this.danyakDataSet = new PracticZadacha.danyakDataSet();
            this.dopyslygiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dopyslygiTableAdapter = new PracticZadacha.danyakDataSetTableAdapters.dopyslygiTableAdapter();
            this.tableAdapterManager = new PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager();
            this.dopyslygiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dopyslygiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dopyslygiDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiBindingNavigator)).BeginInit();
            this.dopyslygiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // danyakDataSet
            // 
            this.danyakDataSet.DataSetName = "danyakDataSet";
            this.danyakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dopyslygiBindingSource
            // 
            this.dopyslygiBindingSource.DataMember = "dopyslygi";
            this.dopyslygiBindingSource.DataSource = this.danyakDataSet;
            // 
            // dopyslygiTableAdapter
            // 
            this.dopyslygiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bronTableAdapter = null;
            this.tableAdapterManager.dolzhnostTableAdapter = null;
            this.tableAdapterManager.dopyslygikogdaTableAdapter = null;
            this.tableAdapterManager.dopyslygiTableAdapter = this.dopyslygiTableAdapter;
            this.tableAdapterManager.klientTableAdapter = null;
            this.tableAdapterManager.komnatanomerTableAdapter = null;
            this.tableAdapterManager.sdelkaTableAdapter = null;
            this.tableAdapterManager.sotrydnikiTableAdapter = null;
            this.tableAdapterManager.TypenomeraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dopyslygiBindingNavigator
            // 
            this.dopyslygiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dopyslygiBindingNavigator.BindingSource = this.dopyslygiBindingSource;
            this.dopyslygiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dopyslygiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dopyslygiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dopyslygiBindingNavigatorSaveItem});
            this.dopyslygiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dopyslygiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dopyslygiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dopyslygiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dopyslygiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dopyslygiBindingNavigator.Name = "dopyslygiBindingNavigator";
            this.dopyslygiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dopyslygiBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.dopyslygiBindingNavigator.TabIndex = 0;
            this.dopyslygiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dopyslygiBindingNavigatorSaveItem
            // 
            this.dopyslygiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dopyslygiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dopyslygiBindingNavigatorSaveItem.Image")));
            this.dopyslygiBindingNavigatorSaveItem.Name = "dopyslygiBindingNavigatorSaveItem";
            this.dopyslygiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dopyslygiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dopyslygiBindingNavigatorSaveItem.Click += new System.EventHandler(this.dopyslygiBindingNavigatorSaveItem_Click);
            // 
            // dopyslygiDataGridView
            // 
            this.dopyslygiDataGridView.AutoGenerateColumns = false;
            this.dopyslygiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dopyslygiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dopyslygiDataGridView.DataSource = this.dopyslygiBindingSource;
            this.dopyslygiDataGridView.Location = new System.Drawing.Point(12, 28);
            this.dopyslygiDataGridView.Name = "dopyslygiDataGridView";
            this.dopyslygiDataGridView.Size = new System.Drawing.Size(365, 207);
            this.dopyslygiDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Оформление Доп.Услуги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_yslygitype";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер услуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "priceyslygi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Прайс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dopyskygi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(387, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dopyslygiDataGridView);
            this.Controls.Add(this.dopyslygiBindingNavigator);
            this.Name = "dopyskygi";
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.dopyskygi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiBindingNavigator)).EndInit();
            this.dopyslygiBindingNavigator.ResumeLayout(false);
            this.dopyslygiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dopyslygiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private danyakDataSet danyakDataSet;
        private System.Windows.Forms.BindingSource dopyslygiBindingSource;
        private danyakDataSetTableAdapters.dopyslygiTableAdapter dopyslygiTableAdapter;
        private danyakDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dopyslygiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dopyslygiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dopyslygiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}