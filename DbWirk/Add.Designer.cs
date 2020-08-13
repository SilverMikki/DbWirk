namespace DbWirk
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.additem = new System.Windows.Forms.Button();
            this.firmTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pubnumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.defectfTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.garantComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataSet = new DbWirk.CityDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.firmComboBox = new System.Windows.Forms.ComboBox();
            this.pubnumComboBox = new System.Windows.Forms.ComboBox();
            this.defectComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.subTextBox = new System.Windows.Forms.TextBox();
            this.datecomeCalendar = new System.Windows.Forms.DateTimePicker();
            this.dateserviceCalendar = new System.Windows.Forms.DateTimePicker();
            this.typemodelComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cityTableAdapter = new DbWirk.CityDataSetTableAdapters.CityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(284, 19);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(167, 20);
            this.cityTextBox.TabIndex = 1;
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(15, 385);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(436, 44);
            this.additem.TabIndex = 2;
            this.additem.Text = "Добавить";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // firmTextBox
            // 
            this.firmTextBox.Location = new System.Drawing.Point(284, 46);
            this.firmTextBox.Name = "firmTextBox";
            this.firmTextBox.Size = new System.Drawing.Size(167, 20);
            this.firmTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фирма";
            // 
            // pubnumTextBox
            // 
            this.pubnumTextBox.Location = new System.Drawing.Point(284, 72);
            this.pubnumTextBox.Name = "pubnumTextBox";
            this.pubnumTextBox.Size = new System.Drawing.Size(167, 20);
            this.pubnumTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Публинчый номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата прихода";
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(111, 126);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(340, 20);
            this.cardTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Карта";
            // 
            // defectfTextBox
            // 
            this.defectfTextBox.Location = new System.Drawing.Point(284, 152);
            this.defectfTextBox.Name = "defectfTextBox";
            this.defectfTextBox.Size = new System.Drawing.Size(167, 20);
            this.defectfTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дефект";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата ремонта";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(284, 204);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(167, 20);
            this.modelTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Модель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Гарантия";
            // 
            // garantComboBox
            // 
            this.garantComboBox.FormattingEnabled = true;
            this.garantComboBox.Location = new System.Drawing.Point(111, 230);
            this.garantComboBox.Name = "garantComboBox";
            this.garantComboBox.Size = new System.Drawing.Size(167, 21);
            this.garantComboBox.TabIndex = 18;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource, "City", true));
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cityBindingSource, "City", true));
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cityBindingSource, "City", true));
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "City", true));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(111, 19);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(167, 21);
            this.cityComboBox.TabIndex = 20;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDataSet;
            // 
            // cityDataSet
            // 
            this.cityDataSet.DataSetName = "CityDataSet";
            this.cityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Примечание";
            // 
            // firmComboBox
            // 
            this.firmComboBox.FormattingEnabled = true;
            this.firmComboBox.Location = new System.Drawing.Point(111, 45);
            this.firmComboBox.Name = "firmComboBox";
            this.firmComboBox.Size = new System.Drawing.Size(167, 21);
            this.firmComboBox.TabIndex = 22;
            // 
            // pubnumComboBox
            // 
            this.pubnumComboBox.FormattingEnabled = true;
            this.pubnumComboBox.Location = new System.Drawing.Point(111, 71);
            this.pubnumComboBox.Name = "pubnumComboBox";
            this.pubnumComboBox.Size = new System.Drawing.Size(167, 21);
            this.pubnumComboBox.TabIndex = 23;
            // 
            // defectComboBox
            // 
            this.defectComboBox.FormattingEnabled = true;
            this.defectComboBox.Location = new System.Drawing.Point(111, 151);
            this.defectComboBox.Name = "defectComboBox";
            this.defectComboBox.Size = new System.Drawing.Size(167, 21);
            this.defectComboBox.TabIndex = 26;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(111, 203);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(167, 21);
            this.modelComboBox.TabIndex = 28;
            // 
            // subTextBox
            // 
            this.subTextBox.Location = new System.Drawing.Point(111, 258);
            this.subTextBox.Multiline = true;
            this.subTextBox.Name = "subTextBox";
            this.subTextBox.Size = new System.Drawing.Size(340, 88);
            this.subTextBox.TabIndex = 29;
            // 
            // datecomeCalendar
            // 
            this.datecomeCalendar.Location = new System.Drawing.Point(111, 98);
            this.datecomeCalendar.Name = "datecomeCalendar";
            this.datecomeCalendar.Size = new System.Drawing.Size(340, 20);
            this.datecomeCalendar.TabIndex = 30;
            // 
            // dateserviceCalendar
            // 
            this.dateserviceCalendar.Location = new System.Drawing.Point(111, 178);
            this.dateserviceCalendar.Name = "dateserviceCalendar";
            this.dateserviceCalendar.Size = new System.Drawing.Size(340, 20);
            this.dateserviceCalendar.TabIndex = 31;
            this.dateserviceCalendar.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // typemodelComboBox
            // 
            this.typemodelComboBox.FormattingEnabled = true;
            this.typemodelComboBox.Location = new System.Drawing.Point(111, 352);
            this.typemodelComboBox.Name = "typemodelComboBox";
            this.typemodelComboBox.Size = new System.Drawing.Size(167, 21);
            this.typemodelComboBox.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Тип модели";
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.typemodelComboBox);
            this.Controls.Add(this.dateserviceCalendar);
            this.Controls.Add(this.datecomeCalendar);
            this.Controls.Add(this.subTextBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.defectComboBox);
            this.Controls.Add(this.pubnumComboBox);
            this.Controls.Add(this.firmComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.garantComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.defectfTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pubnumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.TextBox firmTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pubnumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox defectfTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox garantComboBox;
        public System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox firmComboBox;
        public System.Windows.Forms.ComboBox pubnumComboBox;
        public System.Windows.Forms.ComboBox defectComboBox;
        public System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.TextBox subTextBox;
        private System.Windows.Forms.DateTimePicker datecomeCalendar;
        private System.Windows.Forms.DateTimePicker dateserviceCalendar;
        public System.Windows.Forms.ComboBox typemodelComboBox;
        private System.Windows.Forms.Label label11;
        private CityDataSet cityDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDataSetTableAdapters.CityTableAdapter cityTableAdapter;
    }
}