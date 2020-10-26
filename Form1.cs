using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOwnGoogleMapsWinFormApp
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = textBox1.Text;
            string city = textBox2.Text;
            string state = textBox3.Text;
            string postCode = textBox4.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("https://www.google.com/maps?q=");

                if(street !=string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                }
                if (postCode != string.Empty)
                {
                    queryData.Append(postCode + "," + "+");
                }
                webBrowser1.Navigate(queryData.ToString());
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }


        }
    }
}
