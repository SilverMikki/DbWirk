namespace DbWirk
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.card = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.techIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDataSet = new DbWirk.ServiceDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DbWorker = new System.Windows.Forms.DataGridView();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new DbWirk.ServiceDataSetTableAdapters.ServiceTableAdapter();
            this.FirmcomboBox = new System.Windows.Forms.ComboBox();
            this.DefectcomboBox = new System.Windows.Forms.ComboBox();
            this.ModelcomboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.ModelcomboBox);
            this.panel2.Controls.Add(this.DefectcomboBox);
            this.panel2.Controls.Add(this.FirmcomboBox);
            this.panel2.Controls.Add(this.card);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 649);
            this.panel2.TabIndex = 1;
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(9, 110);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(182, 46);
            this.card.TabIndex = 9;
            this.card.Text = "Карта";
            this.card.UseVisualStyleBackColor = true;
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 545);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 46);
            this.button6.TabIndex = 8;
            this.button6.Text = "Модели";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Неисправности";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Фирмы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сделано - не сделано";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.DbWorker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 649);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.techIdDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.firmDataGridViewTextBoxColumn,
            this.pubnumDataGridViewTextBoxColumn,
            this.datecomeDataGridViewTextBoxColumn,
            this.cardDataGridViewTextBoxColumn,
            this.defectDataGridViewTextBoxColumn,
            this.dateserviceDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.garantDataGridViewTextBoxColumn,
            this.subDataGridViewTextBoxColumn,
            this.typemodelDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.serviceBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1019, 623);
            this.dataGridView2.TabIndex = 2;
            // 
            // techIdDataGridViewTextBoxColumn
            // 
            this.techIdDataGridViewTextBoxColumn.DataPropertyName = "TechId";
            this.techIdDataGridViewTextBoxColumn.HeaderText = "Порядковый номер";
            this.techIdDataGridViewTextBoxColumn.Name = "techIdDataGridViewTextBoxColumn";
            this.techIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // firmDataGridViewTextBoxColumn
            // 
            this.firmDataGridViewTextBoxColumn.DataPropertyName = "firm";
            this.firmDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.firmDataGridViewTextBoxColumn.Name = "firmDataGridViewTextBoxColumn";
            // 
            // pubnumDataGridViewTextBoxColumn
            // 
            this.pubnumDataGridViewTextBoxColumn.DataPropertyName = "pubnum";
            this.pubnumDataGridViewTextBoxColumn.HeaderText = "Публичный номер";
            this.pubnumDataGridViewTextBoxColumn.Name = "pubnumDataGridViewTextBoxColumn";
            // 
            // datecomeDataGridViewTextBoxColumn
            // 
            this.datecomeDataGridViewTextBoxColumn.DataPropertyName = "datecome";
            this.datecomeDataGridViewTextBoxColumn.HeaderText = "Дата прихода";
            this.datecomeDataGridViewTextBoxColumn.Name = "datecomeDataGridViewTextBoxColumn";
            // 
            // cardDataGridViewTextBoxColumn
            // 
            this.cardDataGridViewTextBoxColumn.DataPropertyName = "card";
            this.cardDataGridViewTextBoxColumn.HeaderText = "Карта";
            this.cardDataGridViewTextBoxColumn.Name = "cardDataGridViewTextBoxColumn";
            // 
            // defectDataGridViewTextBoxColumn
            // 
            this.defectDataGridViewTextBoxColumn.DataPropertyName = "defect";
            this.defectDataGridViewTextBoxColumn.HeaderText = "Дефект";
            this.defectDataGridViewTextBoxColumn.Name = "defectDataGridViewTextBoxColumn";
            // 
            // dateserviceDataGridViewTextBoxColumn
            // 
            this.dateserviceDataGridViewTextBoxColumn.DataPropertyName = "dateservice";
            this.dateserviceDataGridViewTextBoxColumn.HeaderText = "Дата ремонта";
            this.dateserviceDataGridViewTextBoxColumn.Name = "dateserviceDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // garantDataGridViewTextBoxColumn
            // 
            this.garantDataGridViewTextBoxColumn.DataPropertyName = "garant";
            this.garantDataGridViewTextBoxColumn.HeaderText = "Гарантия";
            this.garantDataGridViewTextBoxColumn.Name = "garantDataGridViewTextBoxColumn";
            // 
            // subDataGridViewTextBoxColumn
            // 
            this.subDataGridViewTextBoxColumn.DataPropertyName = "sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            // 
            // typemodelDataGridViewTextBoxColumn
            // 
            this.typemodelDataGridViewTextBoxColumn.DataPropertyName = "typemodel";
            this.typemodelDataGridViewTextBoxColumn.HeaderText = "Свой/не свой";
            this.typemodelDataGridViewTextBoxColumn.Name = "typemodelDataGridViewTextBoxColumn";
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.serviceDataSet;
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 623);
            this.dataGridView1.TabIndex = 1;
            // 
            // DbWorker
            // 
            this.DbWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbWorker.Location = new System.Drawing.Point(6, 6);
            this.DbWorker.Name = "DbWorker";
            this.DbWorker.Size = new System.Drawing.Size(920, 623);
            this.DbWorker.TabIndex = 0;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = typeof(DbWirk.WorkerDataSet);
            // 
            // viewBindingSource
            // 
            this.viewBindingSource.DataMember = "View";
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // FirmcomboBox
            // 
            this.FirmcomboBox.FormattingEnabled = true;
            this.FirmcomboBox.Location = new System.Drawing.Point(9, 439);
            this.FirmcomboBox.Name = "FirmcomboBox";
            this.FirmcomboBox.Size = new System.Drawing.Size(182, 21);
            this.FirmcomboBox.TabIndex = 10;
            // 
            // DefectcomboBox
            // 
            this.DefectcomboBox.FormattingEnabled = true;
            this.DefectcomboBox.Location = new System.Drawing.Point(9, 518);
            this.DefectcomboBox.Name = "DefectcomboBox";
            this.DefectcomboBox.Size = new System.Drawing.Size(182, 21);
            this.DefectcomboBox.TabIndex = 11;
            // 
            // ModelcomboBox
            // 
            this.ModelcomboBox.FormattingEnabled = true;
            this.ModelcomboBox.Location = new System.Drawing.Point(9, 597);
            this.ModelcomboBox.Name = "ModelcomboBox";
            this.ModelcomboBox.Size = new System.Drawing.Size(182, 21);
            this.ModelcomboBox.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 697);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DbWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource viewBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn techIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private ServiceDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.ComboBox ModelcomboBox;
        private System.Windows.Forms.ComboBox DefectcomboBox;
        private System.Windows.Forms.ComboBox FirmcomboBox;
    }
}

