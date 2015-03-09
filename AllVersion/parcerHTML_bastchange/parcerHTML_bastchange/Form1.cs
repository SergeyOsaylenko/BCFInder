using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace parcerHTML_bastchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient w = new WebClient();
            string page = w.DownloadString("http://www.bestchange.ru/list.html");

            DataSet ds = new DataSet();
            ds.Tables.Add("my");

            string[] col = { "Обменник", "Резервы", "Курсов", "Статус", "BL", "Отзывы" };


            foreach (string nameCol in col)
            {
                ds.Tables[0].Columns.Add(nameCol);

            }

                 

            string srcData = "<div class=\"ca\">(.*?)</div></div></div></td>"
                         + "<td class=\"ar arp\">(.*?)</small></td>\n"
                        + "<td class=\"ar arp\">(.*?)</small></td>\n"
                        + "<td class=\"bj bp\">(.*?)</td>\n";
                       
                         
            string row = null;
            string[] rvalue = null;
            foreach (Match match in Regex.Matches(page, srcData))
            {

                row = match.Groups[1].Value + " | "
                                      + match.Groups[2].Value + " | "
                                      + match.Groups[3].Value + " | "
                                      + match.Groups[4].Value + " | ";
                                     

                rvalue = row.Split(new Char[] { '|' });

                ds.Tables[0].Rows.Add(rvalue);

                dataGridView1.DataSource = ds.Tables[0];

                row = null;
                rvalue = null;
            }

            dataGridView1.Columns[4].Visible=false;
            dataGridView1.Columns[5].Visible = false; 

  

        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            WebClient w = new WebClient();
            string page = w.DownloadString("http://www.bestchange.ru/wmz-to-privat24-uah.html");

            DataSet ds = new DataSet();
            ds.Tables.Add("my");
       
            string[] col = { "Обменник", "Отдаете", "Получаете", "Резерв", "Отзывы" };
          

            foreach (string nameCol in col)
            {
                ds.Tables[0].Columns.Add(nameCol);

            }
        

            string srcData = "<div class=\"ca\">(.*?)</div></div></div></td>"
                        + "<td class=\"bi\">(.*?)<small>(.*?)</small></td>\n"
                        + "<td class=\"bi\">(.*?)<small>(.*?)</small></td>\n"
                        + "<td class=\"ar arp\" (.*?)>(.*?)</td>\n"
                        + "(.*?)<td class=\"rwl\">(.*?)</td><td class=\"del\">(.*?)</td>"
                        + "<td class=\"rwr pos\">(.*?)</td>";

            string row = null;
            string[] rvalue = null;
            foreach (Match match in Regex.Matches(page, srcData))
            {

                row = match.Groups[1].Value + " | "
                                     + match.Groups[2].Value
                                     + match.Groups[3].Value + " | "
                                     + match.Groups[4].Value
                                     + match.Groups[5].Value + " | "
                                     + match.Groups[7].Value + " | "
                                     + match.Groups[9].Value
                                     + match.Groups[10].Value
                                     + match.Groups[11].Value;

                rvalue = row.Split(new Char[] { '|' });

                ds.Tables[0].Rows.Add(rvalue);

                dataGridView1.DataSource = ds.Tables[0];

                row = null;
                rvalue = null;
            }





        }

       
        private void button3_Click(object sender, EventArgs e)
        {
             
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Обменник"].Value);
                string[] namewebsite = { "RoboxChange", "WMIrk", "EasyChange", "СуперОбменка&sup2;", "SuperChange&sup2; ", "SaveChange", "Обменник.ws", "Меняла", " NetExchange&sup2;", "WMCasher", "UkrWM", "Wmt24", " DemonChange&sup2;", "Обменка", "IntExchange", "eMoney16", "WMtoCash" };
                string[] website = { "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://wmirk.ru/?prt=6bf875c78c9e5bc2d343b372ee5152b2", "https://easychange.ru/index.php?pid=5", "http://superobmenka.net/ru/?partner_id=9", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru", "https://www.roboxchange.com/Index.aspx?p=bestc&Culture=ru" };
                
                for (int i = 0; i <= 10; i++)
                {
                    if (a.Contains(namewebsite[i])) { System.Diagnostics.Process.Start(website[i]); };
                }
  
              
               
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {


                WebClient w = new WebClient();
                string page = w.DownloadString("http://www.bestchange.ru/wmz-to-wmr.html");

                DataSet ds = new DataSet();
                ds.Tables.Add("my");

                string[] col = { "Обменник", "Отдаете", "Получаете", "Резерв", "Отзывы" };


                foreach (string nameCol in col)
                {
                    ds.Tables[0].Columns.Add(nameCol);

                }

                     

                string srcData = "<div class=\"ca\">(.*?)</div></div></div></td>"
                            + "<td class=\"bi\">(.*?)<small>(.*?)</small></td>\n"
                            + "<td class=\"bi\">(.*?)<small>(.*?)</small></td>\n"
                            + "<td class=\"ar arp\" (.*?)>(.*?)</td>\n"
                            + "(.*?)<td class=\"rwl\">(.*?)</td><td class=\"del\">(.*?)</td>"
                            + "<td class=\"rwr pos\">(.*?)</td>";

                string row = null;
                string[] rvalue = null;
                foreach (Match match in Regex.Matches(page, srcData))
                {

                    row = match.Groups[1].Value + " | "
                                         + match.Groups[2].Value
                                         + match.Groups[3].Value + " | "
                                         + match.Groups[4].Value
                                         + match.Groups[5].Value + " | "
                                         + match.Groups[7].Value + " | "
                                         + match.Groups[9].Value
                                         + match.Groups[10].Value
                                         + match.Groups[11].Value;

                    rvalue = row.Split(new Char[] { '|' });

                    ds.Tables[0].Rows.Add(rvalue);

                    dataGridView1.DataSource = ds.Tables[0];

                    row = null;
                    rvalue = null;
                }





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WebClient w = new WebClient();
            string page = w.DownloadString("http://www.bestchange.ru/list.html");

            DataSet ds = new DataSet();
            ds.Tables.Add("my");

            string[] col = { "Обменник", "Резервы", "Курсов", "Статус", "BL", "Отзывы" };


            foreach (string nameCol in col)
            {
                ds.Tables[0].Columns.Add(nameCol);

            }

                      

            string srcData = "<div class=\"ca\">(.*?)</div></div></div></td>"
                         + "<td class=\"ar arp\">(.*?)</small></td>\n"
                        + "<td class=\"ar arp\">(.*?)</small></td>\n"
                        + "<td class=\"bj bp\">(.*?)</td>\n";


            string row = null;
            string[] rvalue = null;
            foreach (Match match in Regex.Matches(page, srcData))
            {

                row = match.Groups[1].Value + " | "
                                      + match.Groups[2].Value + " | "
                                      + match.Groups[3].Value + " | "
                                      + match.Groups[4].Value + " | ";


                rvalue = row.Split(new Char[] { '|' });

                ds.Tables[0].Rows.Add(rvalue);

                dataGridView1.DataSource = ds.Tables[0];

                row = null;
                rvalue = null;
            }
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false; 
        }
        
            
        }

        
    }

