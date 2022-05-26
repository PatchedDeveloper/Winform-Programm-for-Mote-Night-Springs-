
namespace PracticZadacha
{
    partial class room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room));
            this.danyakDataSet = new PracticZadacha.danyakDataSet();
            this.komnatanomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komnatanomerTableAdapter = new PracticZadacha.danyakDataSetTableAdapters.komnatanomerTableAdapter();
            this.tableAdapterManager = new PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager();
            this.komnatanomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.komnatanomerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.komnatanomerDataGridView = new System.Windows.Forms.DataGridView();
            this.typenomeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typenomeraTableAdapter = new PracticZadacha.danyakDataSetTableAdapters.TypenomeraTableAdapter();
            this.typenomeraDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idkomnatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krovatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerBindingNavigator)).BeginInit();
            this.komnatanomerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenomeraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenomeraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // danyakDataSet
            // 
            this.danyakDataSet.DataSetName = "danyakDataSet";
            this.danyakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // komnatanomerBindingSource
            // 
            this.komnatanomerBindingSource.DataMember = "komnatanomer";
            this.komnatanomerBindingSource.DataSource = this.danyakDataSet;
            // 
            // komnatanomerTableAdapter
            // 
            this.komnatanomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bronTableAdapter = null;
            this.tableAdapterManager.dolzhnostTableAdapter = null;
            this.tableAdapterManager.dopyslygikogdaTableAdapter = null;
            this.tableAdapterManager.dopyslygiTableAdapter = null;
            this.tableAdapterManager.klientTableAdapter = null;
            this.tableAdapterManager.komnatanomerTableAdapter = this.komnatanomerTableAdapter;
            this.tableAdapterManager.sdelkaTableAdapter = null;
            this.tableAdapterManager.sotrydnikiTableAdapter = null;
            this.tableAdapterManager.TypenomeraTableAdapter = this.typenomeraTableAdapter;
            this.tableAdapterManager.UpdateOrder = PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // komnatanomerBindingNavigator
            // 
            this.komnatanomerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.komnatanomerBindingNavigator.BindingSource = this.komnatanomerBindingSource;
            this.komnatanomerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.komnatanomerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.komnatanomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.komnatanomerBindingNavigatorSaveItem});
            this.komnatanomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.komnatanomerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.komnatanomerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.komnatanomerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.komnatanomerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.komnatanomerBindingNavigator.Name = "komnatanomerBindingNavigator";
            this.komnatanomerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.komnatanomerBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.komnatanomerBindingNavigator.TabIndex = 0;
            this.komnatanomerBindingNavigator.Text = "bindingNavigator1";
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
            // komnatanomerBindingNavigatorSaveItem
            // 
            this.komnatanomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.komnatanomerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("komnatanomerBindingNavigatorSaveItem.Image")));
            this.komnatanomerBindingNavigatorSaveItem.Name = "komnatanomerBindingNavigatorSaveItem";
            this.komnatanomerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.komnatanomerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.komnatanomerBindingNavigatorSaveItem.Click += new System.EventHandler(this.komnatanomerBindingNavigatorSaveItem_Click);
            // 
            // komnatanomerDataGridView
            // 
            this.komnatanomerDataGridView.AutoGenerateColumns = false;
            this.komnatanomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.komnatanomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkomnatyDataGridViewTextBoxColumn,
            this.idNomerDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.krovatyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.komnatanomerDataGridView.DataSource = this.komnatanomerBindingSource;
            this.komnatanomerDataGridView.Location = new System.Drawing.Point(0, 28);
            this.komnatanomerDataGridView.Name = "komnatanomerDataGridView";
            this.komnatanomerDataGridView.Size = new System.Drawing.Size(578, 220);
            this.komnatanomerDataGridView.TabIndex = 1;
            // 
            // typenomeraBindingSource
            // 
            this.typenomeraBindingSource.DataMember = "Typenomera";
            this.typenomeraBindingSource.DataSource = this.danyakDataSet;
            // 
            // typenomeraTableAdapter
            // 
            this.typenomeraTableAdapter.ClearBeforeFill = true;
            // 
            // typenomeraDataGridView
            // 
            this.typenomeraDataGridView.AutoGenerateColumns = false;
            this.typenomeraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typenomeraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.typenomeraDataGridView.DataSource = this.typenomeraBindingSource;
            this.typenomeraDataGridView.Location = new System.Drawing.Point(584, 28);
            this.typenomeraDataGridView.Name = "typenomeraDataGridView";
            this.typenomeraDataGridView.Size = new System.Drawing.Size(277, 220);
            this.typenomeraDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество кроватей:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBox1.Location = new System.Drawing.Point(330, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBox2.Location = new System.Drawing.Point(439, 263);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 35);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Две";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idkomnatyDataGridViewTextBoxColumn
            // 
            this.idkomnatyDataGridViewTextBoxColumn.DataPropertyName = "id_komnaty";
            this.idkomnatyDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.idkomnatyDataGridViewTextBoxColumn.Name = "idkomnatyDataGridViewTextBoxColumn";
            this.idkomnatyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNomerDataGridViewTextBoxColumn
            // 
            this.idNomerDataGridViewTextBoxColumn.DataPropertyName = "Id_Nomer";
            this.idNomerDataGridViewTextBoxColumn.HeaderText = "Номер типа";
            this.idNomerDataGridViewTextBoxColumn.Name = "idNomerDataGridViewTextBoxColumn";
            // 
            // etageDataGridViewTextBoxColumn
            // 
            this.etageDataGridViewTextBoxColumn.DataPropertyName = "etage";
            this.etageDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
            // 
            // krovatyDataGridViewTextBoxColumn
            // 
            this.krovatyDataGridViewTextBoxColumn.DataPropertyName = "krovaty";
            this.krovatyDataGridViewTextBoxColumn.HeaderText = "Кроватей";
            this.krovatyDataGridViewTextBoxColumn.Name = "krovatyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_Nomer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер типа";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn7.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(348, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Одна";
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(865, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typenomeraDataGridView);
            this.Controls.Add(this.komnatanomerDataGridView);
            this.Controls.Add(this.komnatanomerBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "room";
            this.Text = "room";
            this.Load += new System.EventHandler(this.room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerBindingNavigator)).EndInit();
            this.komnatanomerBindingNavigator.ResumeLayout(false);
            this.komnatanomerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komnatanomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenomeraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenomeraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private danyakDataSet danyakDataSet;
        private System.Windows.Forms.BindingSource komnatanomerBindingSource;
        private danyakDataSetTableAdapters.komnatanomerTableAdapter komnatanomerTableAdapter;
        private danyakDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator komnatanomerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton komnatanomerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView komnatanomerDataGridView;
        private danyakDataSetTableAdapters.TypenomeraTableAdapter typenomeraTableAdapter;
        private System.Windows.Forms.BindingSource typenomeraBindingSource;
        private System.Windows.Forms.DataGridView typenomeraDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkomnatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krovatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
    }
}