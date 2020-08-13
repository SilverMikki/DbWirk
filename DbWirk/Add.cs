using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace DbWirk
{
    public partial class Add : Form
    {
        
        public Add()
        {
            InitializeComponent();
            Parallel.Invoke(
            () => { FillCityComboBox(); },
            () => { FillGarantComboBox(); },
            () => { FillPubnumComboBox(); },
            () => { FillFirmComboBox(); },
            () => { FillDefectComboBox(); },
            () => { FillModelComboBox(); },
            () => { FillTypemodelComboBox(); });
        }
        #region Fill
        private void FillCityComboBox()
        {
            foreach(string item in Engine.arrayCity)
            {
                cityComboBox.Items.Add(item);
            }
        }

        private void FillTypemodelComboBox()
        {
            foreach (string item in Engine.arrayTypemodel)
            {
                typemodelComboBox.Items.Add(item);
            }
        }

        private void FillModelComboBox()
        {
            foreach (string item in Engine.arrayModel)
            {
                modelComboBox.Items.Add(item);
            }
        }

        private void FillDefectComboBox()
        {
            foreach (string item in Engine.arrayDefect)
            {
                defectComboBox.Items.Add(item);
            }
        }
        
        private void FillFirmComboBox()
        {
            foreach (string item in Engine.arrayFirm)
            {
               firmComboBox.Items.Add(item);
            }
        }

        private void FillGarantComboBox()
        {
            foreach (string item in Engine.arrayGarant)
            {
                garantComboBox.Items.Add(item);
            }
        }

        private void FillPubnumComboBox()
        {
            foreach (string item in Engine.arrayPubnum)
            {
                pubnumComboBox.Items.Add(item);
            }
        }
        #endregion
        private void additem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> add = new Dictionary<string, string>();
            add.Add("city", Engine.Encrypt(Engine.Choice(cityComboBox.GetItemText(this.cityComboBox.SelectedItem), cityTextBox.Text, "city")));
            add.Add("firm", Engine.Encrypt(Engine.Choice(firmComboBox.GetItemText(this.firmComboBox.SelectedItem), firmTextBox.Text.ToString(), "firm")));
            add.Add("pubnum", Engine.Encrypt(Engine.Choice(pubnumComboBox.GetItemText(this.pubnumComboBox.SelectedItem), pubnumTextBox.Text.ToString(), "pubnum")));
            add.Add("datecome", Engine.Encrypt(datecomeCalendar.Value.Day.ToString() + "." + datecomeCalendar.Value.Month.ToString() + "." + datecomeCalendar.Value.Year.ToString()));
            add.Add("card", Engine.Encrypt(cardTextBox.Text.ToString()));
            add.Add("defect", Engine.Encrypt(Engine.Choice(defectComboBox.GetItemText(this.defectComboBox.SelectedItem), firmTextBox.Text.ToString(), "defect")));
            add.Add("dateservice", Engine.Encrypt(dateserviceCalendar.Value.Day.ToString() + "." + dateserviceCalendar.Value.Month.ToString() + "." + dateserviceCalendar.Value.Year.ToString()));
            add.Add("model", Engine.Encrypt(Engine.Choice(modelComboBox.GetItemText(this.modelComboBox.SelectedItem), modelTextBox.Text ,"model")));
            add.Add("garant", Engine.Encrypt(garantComboBox.GetItemText(this.garantComboBox.SelectedItem)));
            add.Add("sub", Engine.Encrypt(subTextBox.Text.ToString()));
            add.Add("typemodel", Engine.Encrypt(typemodelComboBox.GetItemText(this.typemodelComboBox.SelectedItem)));
            Engine.Add(add);
            main Main = new main();
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cityDataSet.City". При необходимости она может быть перемещена или удалена.
            //this.cityTableAdapter.Fill(this.cityDataSet.City);

        }
    }
}
