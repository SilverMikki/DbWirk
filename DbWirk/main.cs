using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace DbWirk
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            
        }

        private void data()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        


        private void button5_Click(object sender, EventArgs e)
        {
            var select = "select * from Service";
            var dataAdapter = new SqlDataAdapter(select, Engine.connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DataTable dt = new DataTable("DataTable");
            dt.Columns.Add("TechId");
            dt.Columns.Add("city");
            dt.Columns.Add("firm");
            dt.Columns.Add("pubnum");
            dt.Columns.Add("datecome");
            dt.Columns.Add("card");
            dt.Columns.Add("defect");
            dt.Columns.Add("dateservice");
            dt.Columns.Add("model");
            dt.Columns.Add("garant");
            dt.Columns.Add("sub");
            dt.Columns.Add("typemodel");


            List<string> strDetailIDList = new List<string>();
            List<string> strDetailIDList1 = new List<string>();
            List<string> strDetailIDList2 = new List<string>();
            List<string> strDetailIDList3 = new List<string>();
            List<string> strDetailIDList4 = new List<string>();
            List<string> strDetailIDList5 = new List<string>();
            List<string> strDetailIDList6 = new List<string>();
            List<string> strDetailIDList7 = new List<string>();
            List<string> strDetailIDList8 = new List<string>();
            List<string> strDetailIDList9 = new List<string>();
            List<string> strDetailIDList10 = new List<string>();
            List<string> strDetailIDList11 = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row["TechId"].ToString());
                strDetailIDList1.Add(Engine.Decrypt(row["city"].ToString()));
                strDetailIDList2.Add(Engine.Decrypt(row["firm"].ToString()));
                strDetailIDList3.Add(Engine.Decrypt(row["pubnum"].ToString()));
                strDetailIDList4.Add(Engine.Decrypt(row["datecome"].ToString()));
                strDetailIDList5.Add(Engine.Decrypt(row["card"].ToString()));
                strDetailIDList6.Add(Engine.Decrypt(row["defect"].ToString()));
                strDetailIDList7.Add(Engine.Decrypt(row["dateservice"].ToString()));
                strDetailIDList8.Add(Engine.Decrypt(row["model"].ToString()));
                strDetailIDList9.Add(Engine.Decrypt(row["garant"].ToString()));
                strDetailIDList10.Add(Engine.Decrypt(row["sub"].ToString()));
                strDetailIDList11.Add(Engine.Decrypt(row["typemodel"].ToString()));
            }
            
            int len = strDetailIDList.Count;
            for(int j = 0; j < len; j++)
            {
                var rw = dt.NewRow();
                rw[0] = strDetailIDList[j];
                rw[1] = strDetailIDList1[j];
                rw[2] = strDetailIDList2[j];
                rw[3] = strDetailIDList3[j];
                rw[4] = strDetailIDList4[j];
                rw[5] = strDetailIDList5[j];
                rw[6] = strDetailIDList6[j];
                rw[7] = strDetailIDList7[j];
                rw[8] = strDetailIDList8[j];
                rw[9] = strDetailIDList9[j];
                rw[10] = strDetailIDList10[j];
                rw[11] = strDetailIDList11[j];
                dt.Rows.Add(rw);
            }
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private async void main_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                string[] sqlQueries = new string[7];
                sqlQueries[0] = "select city from City";
                sqlQueries[1] = "select typemodel from Typemodel";
                sqlQueries[2] = "select model from Model";
                sqlQueries[3] = "select defect from Defect";
                sqlQueries[4] = "select firm from Firm";
                sqlQueries[5] = "select garant from Garant";
                sqlQueries[6] = "select pubnum from PubNum";
                for (int i = 0; i < sqlQueries.Length; i++)
                {
                    Engine.connection.Close();
                    Engine.connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlQueries[i], Engine.connection);
                    SqlDataReader DR = cmd.ExecuteReader();
                    if (i == 0)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayCity.Add(src);
                        }
                    }
                    if (i == 1)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayTypemodel.Add(src);
                        }
                    }
                    if (i == 2)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayModel.Add(src);
                        }
                    }
                    if (i == 3)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayDefect.Add(src);
                        }
                    }
                    if (i == 4)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayFirm.Add(src);
                        }
                    }
                    if (i == 5)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayGarant.Add(src);
                        }
                    }
                    if (i == 6)
                    {
                        while (DR.Read())
                        {
                            string src = Engine.Decrypt(DR[0].ToString());
                            Engine.arrayPubnum.Add(src);
                        }
                    }
                }
            });
            
            
            
            Engine.connection.Close();
            //Parallel.Invoke(
            //() => { FillCityComboBox(); },
            //() => { FillGarantComboBox(); },
            // () => { FillPubnumComboBox(); },
            //() => { FillFirmComboBox(); },
            // () => { FillDefectComboBox(); },
            // () => { FillModelComboBox(); },
            // () => { FillTypemodelComboBox(); });
            // TODO: This line of code loads data into the 'serviceDataSet.Service' table. You can move, or remove it, as needed.
            //this.serviceTableAdapter.Fill(this.serviceDataSet.Service);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                this.serviceTableAdapter.FillBy(this.serviceDataSet.Service);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void card_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var select = "select * from Service";
            var dataAdapter = new SqlDataAdapter(select, Engine.connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DataTable dt = new DataTable("DataTable");
            dt.Columns.Add("TechId");
            dt.Columns.Add("city");
            dt.Columns.Add("firm");
            dt.Columns.Add("pubnum");
            dt.Columns.Add("datecome");
            dt.Columns.Add("card");
            dt.Columns.Add("defect");
            dt.Columns.Add("dateservice");
            dt.Columns.Add("model");
            dt.Columns.Add("garant");
            dt.Columns.Add("sub");
            dt.Columns.Add("typemodel");


            List<string> strDetailIDList = new List<string>();
            List<string> strDetailIDList1 = new List<string>();
            List<string> strDetailIDList2 = new List<string>();
            List<string> strDetailIDList3 = new List<string>();
            List<string> strDetailIDList4 = new List<string>();
            List<string> strDetailIDList5 = new List<string>();
            List<string> strDetailIDList6 = new List<string>();
            List<string> strDetailIDList7 = new List<string>();
            List<string> strDetailIDList8 = new List<string>();
            List<string> strDetailIDList9 = new List<string>();
            List<string> strDetailIDList10 = new List<string>();
            List<string> strDetailIDList11 = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row["TechId"].ToString());
                strDetailIDList1.Add(Engine.Decrypt(row["city"].ToString()));
                strDetailIDList2.Add(Engine.Decrypt(row["firm"].ToString()));
                strDetailIDList3.Add(Engine.Decrypt(row["pubnum"].ToString()));
                strDetailIDList4.Add(Engine.Decrypt(row["datecome"].ToString()));
                strDetailIDList5.Add(Engine.Decrypt(row["card"].ToString()));
                strDetailIDList6.Add(Engine.Decrypt(row["defect"].ToString()));
                strDetailIDList7.Add(Engine.Decrypt(row["dateservice"].ToString()));
                strDetailIDList8.Add(Engine.Decrypt(row["model"].ToString()));
                strDetailIDList9.Add(Engine.Decrypt(row["garant"].ToString()));
                strDetailIDList10.Add(Engine.Decrypt(row["sub"].ToString()));
                strDetailIDList11.Add(Engine.Decrypt(row["typemodel"].ToString()));
            }
            
            int len = strDetailIDList.Count;
            for (int j = 0; j < len; j++)
            {
                if (strDetailIDList7[j] == "1.1.2000")
                {
                    var rw = dt.NewRow();
                    rw[0] = strDetailIDList[j];
                    rw[1] = strDetailIDList1[j];
                    rw[2] = strDetailIDList2[j];
                    rw[3] = strDetailIDList3[j];
                    rw[4] = strDetailIDList4[j];
                    rw[5] = strDetailIDList5[j];
                    rw[6] = strDetailIDList6[j];
                    rw[7] = strDetailIDList7[j];
                    rw[8] = strDetailIDList8[j];
                    rw[9] = strDetailIDList9[j];
                    rw[10] = strDetailIDList10[j];
                    rw[11] = strDetailIDList11[j];
                    dt.Rows.Add(rw);
                }
            }
            dataGridView2.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            var select = "select * from Service";
            var dataAdapter = new SqlDataAdapter(select, Engine.connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DataTable dt = new DataTable("DataTable");
            dt.Columns.Add("TechId");
            dt.Columns.Add("city");
            dt.Columns.Add("firm");
            dt.Columns.Add("pubnum");
            dt.Columns.Add("datecome");
            dt.Columns.Add("card");
            dt.Columns.Add("defect");
            dt.Columns.Add("dateservice");
            dt.Columns.Add("model");
            dt.Columns.Add("garant");
            dt.Columns.Add("sub");
            dt.Columns.Add("typemodel");


            List<string> strDetailIDList = new List<string>();
            List<string> strDetailIDList1 = new List<string>();
            List<string> strDetailIDList2 = new List<string>();
            List<string> strDetailIDList3 = new List<string>();
            List<string> strDetailIDList4 = new List<string>();
            List<string> strDetailIDList5 = new List<string>();
            List<string> strDetailIDList6 = new List<string>();
            List<string> strDetailIDList7 = new List<string>();
            List<string> strDetailIDList8 = new List<string>();
            List<string> strDetailIDList9 = new List<string>();
            List<string> strDetailIDList10 = new List<string>();
            List<string> strDetailIDList11 = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row["TechId"].ToString());
                strDetailIDList1.Add(Engine.Decrypt(row["city"].ToString()));
                strDetailIDList2.Add(Engine.Decrypt(row["firm"].ToString()));
                strDetailIDList3.Add(Engine.Decrypt(row["pubnum"].ToString()));
                strDetailIDList4.Add(Engine.Decrypt(row["datecome"].ToString()));
                strDetailIDList5.Add(Engine.Decrypt(row["card"].ToString()));
                strDetailIDList6.Add(Engine.Decrypt(row["defect"].ToString()));
                strDetailIDList7.Add(Engine.Decrypt(row["dateservice"].ToString()));
                strDetailIDList8.Add(Engine.Decrypt(row["model"].ToString()));
                strDetailIDList9.Add(Engine.Decrypt(row["garant"].ToString()));
                strDetailIDList10.Add(Engine.Decrypt(row["sub"].ToString()));
                strDetailIDList11.Add(Engine.Decrypt(row["typemodel"].ToString()));
            }
            var rw = dt.NewRow();
            int len = strDetailIDList.Count;
            for (int j = 0; j < len; j++)
            {
                if (strDetailIDList7[j] == "1.1.2000")
                {
                    rw[0] = strDetailIDList[j];
                    rw[1] = strDetailIDList1[j];
                    rw[2] = strDetailIDList2[j];
                    rw[3] = strDetailIDList3[j];
                    rw[4] = strDetailIDList4[j];
                    rw[5] = strDetailIDList5[j];
                    rw[6] = strDetailIDList6[j];
                    rw[7] = strDetailIDList7[j];
                    rw[8] = strDetailIDList8[j];
                    rw[9] = strDetailIDList9[j];
                    rw[10] = strDetailIDList10[j];
                    rw[11] = strDetailIDList11[j];
                    dt.Rows.Add(rw);
                }
            }
            dataGridView2.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
