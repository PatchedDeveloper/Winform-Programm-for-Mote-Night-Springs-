
namespace PracticZadacha
{
    partial class klient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klient));
            this.danyakDataSet = new PracticZadacha.danyakDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new PracticZadacha.danyakDataSetTableAdapters.klientTableAdapter();
            this.tableAdapterManager = new PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager();
            this.klientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.klientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klientDataGridView = new System.Windows.Forms.DataGridView();
            this.idKlientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famKlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameKlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoKlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsKlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).BeginInit();
            this.klientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // danyakDataSet
            // 
            this.danyakDataSet.DataSetName = "danyakDataSet";
            this.danyakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.danyakDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bronTableAdapter = null;
            this.tableAdapterManager.dolzhnostTableAdapter = null;
            this.tableAdapterManager.dopyslygikogdaTableAdapter = null;
            this.tableAdapterManager.dopyslygiTableAdapter = null;
            this.tableAdapterManager.klientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.komnatanomerTableAdapter = null;
            this.tableAdapterManager.sdelkaTableAdapter = null;
            this.tableAdapterManager.sotrydnikiTableAdapter = null;
            this.tableAdapterManager.TypenomeraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PracticZadacha.danyakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klientBindingNavigator
            // 
            this.klientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klientBindingNavigator.BindingSource = this.klientBindingSource;
            this.klientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.klientBindingNavigatorSaveItem});
            this.klientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klientBindingNavigator.Name = "klientBindingNavigator";
            this.klientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klientBindingNavigator.Size = new System.Drawing.Size(766, 25);
            this.klientBindingNavigator.TabIndex = 0;
            this.klientBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // klientBindingNavigatorSaveItem
            // 
            this.klientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klientBindingNavigatorSaveItem.Image")));
            this.klientBindingNavigatorSaveItem.Name = "klientBindingNavigatorSaveItem";
            this.klientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.klientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.klientBindingNavigatorSaveItem.Click += new System.EventHandler(this.klientBindingNavigatorSaveItem_Click);
            // 
            // klientDataGridView
            // 
            this.klientDataGridView.AutoGenerateColumns = false;
            this.klientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientDataGridViewTextBoxColumn,
            this.idKlDataGridViewTextBoxColumn,
            this.famKlDataGridViewTextBoxColumn,
            this.nameKlDataGridViewTextBoxColumn,
            this.otchestvoKlDataGridViewTextBoxColumn,
            this.babyDataGridViewTextBoxColumn,
            this.documentsKlDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.klientDataGridView.DataSource = this.klientBindingSource;
            this.klientDataGridView.Location = new System.Drawing.Point(0, 28);
            this.klientDataGridView.Name = "klientDataGridView";
            this.klientDataGridView.Size = new System.Drawing.Size(764, 220);
            this.klientDataGridView.TabIndex = 1;
            // 
            // idKlientDataGridViewTextBoxColumn
            // 
            this.idKlientDataGridViewTextBoxColumn.DataPropertyName = "Id_Klient";
            this.idKlientDataGridViewTextBoxColumn.HeaderText = "Id_Klient";
            this.idKlientDataGridViewTextBoxColumn.Name = "idKlientDataGridViewTextBoxColumn";
            this.idKlientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKlientDataGridViewTextBoxColumn.Visible = false;
            // 
            // idKlDataGridViewTextBoxColumn
            // 
            this.idKlDataGridViewTextBoxColumn.DataPropertyName = "Id_Kl";
            this.idKlDataGridViewTextBoxColumn.HeaderText = "Id_Kl";
            this.idKlDataGridViewTextBoxColumn.Name = "idKlDataGridViewTextBoxColumn";
            this.idKlDataGridViewTextBoxColumn.Visible = false;
            // 
            // famKlDataGridViewTextBoxColumn
            // 
            this.famKlDataGridViewTextBoxColumn.DataPropertyName = "FamKl";
            this.famKlDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.famKlDataGridViewTextBoxColumn.Name = "famKlDataGridViewTextBoxColumn";
            // 
            // nameKlDataGridViewTextBoxColumn
            // 
            this.nameKlDataGridViewTextBoxColumn.DataPropertyName = "NameKl";
            this.nameKlDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameKlDataGridViewTextBoxColumn.Name = "nameKlDataGridViewTextBoxColumn";
            // 
            // otchestvoKlDataGridViewTextBoxColumn
            // 
            this.otchestvoKlDataGridViewTextBoxColumn.DataPropertyName = "OtchestvoKl";
            this.otchestvoKlDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.otchestvoKlDataGridViewTextBoxColumn.Name = "otchestvoKlDataGridViewTextBoxColumn";
            // 
            // babyDataGridViewTextBoxColumn
            // 
            this.babyDataGridViewTextBoxColumn.DataPropertyName = "Baby";
            this.babyDataGridViewTextBoxColumn.HeaderText = "Ребёнок";
            this.babyDataGridViewTextBoxColumn.Name = "babyDataGridViewTextBoxColumn";
            // 
            // documentsKlDataGridViewTextBoxColumn
            // 
            this.documentsKlDataGridViewTextBoxColumn.DataPropertyName = "documentsKl";
            this.documentsKlDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.documentsKlDataGridViewTextBoxColumn.Name = "documentsKlDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(355, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 26);
            this.button6.TabIndex = 44;
            this.button6.Text = "Добавить запись";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(613, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 26);
            this.button5.TabIndex = 43;
            this.button5.Text = "Сброс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(484, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 26);
            this.button4.TabIndex = 42;
            this.button4.Text = "Отчеты";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 28);
            this.button3.TabIndex = 41;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 32);
            this.button2.TabIndex = 40;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 39;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(426, 357);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 24);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 321);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 30);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 28);
            this.textBox1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(15, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Поиск по номеру документа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(15, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Поиск по Фамилии:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(15, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поиск по Имени:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(15, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Поиск по возрастной категории:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBox1.Location = new System.Drawing.Point(460, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 35);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Ребёнок";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBox2.Location = new System.Drawing.Point(608, 387);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 35);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "Взрослый";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(766, 426);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klientDataGridView);
            this.Controls.Add(this.klientBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "klient";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danyakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).EndInit();
            this.klientBindingNavigator.ResumeLayout(false);
            this.klientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private danyakDataSet danyakDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private danyakDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private danyakDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton klientBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView klientDataGridView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famKlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameKlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoKlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsKlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}