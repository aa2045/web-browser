using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDraft1
{
    public partial class HistoryForm : Form
    {
        private Browser b; // An object of Browser class is instantiated
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }
        public void SetHistory(History h, Browser b)
        {
            List<string> data = h.getHistory();
            foreach(string s in data)
            {
                this.hview.Items.Add(s);
            }
         

            this.b = b;
        }

        private void connect(string url)
        {
            string statusCode = b.getStatuscode();
            string statusDecription = b.getStatusDescription();

           // this.addressBox.Text = url;

            if (statusCode.Equals("200"))
            {
                //this.titlelbl.Text = b.getTitle();
                //this.titlelbl.ForeColor = Color.Green;
                this.statusCodelbl.Text = statusCode + " " + statusDecription;
                this.statusCodelbl.ForeColor = Color.Green;
                this.htmlTextBX.Text = b.getHtmlContent();

                //add it to the history listview
                string[] arr = new string[1];
                arr[0] = url;
                ListViewItem item = new ListViewItem(arr);
                this.hview.Items.Add(item);

                //setHistory(h,url);
            }
            else
            {
                Console.WriteLine(statusCode);
                this.statusCodelbl.Text = statusCode + " " + statusDecription;
                this.statusCodelbl.ForeColor = Color.Red;
                //this.titlelbl.Text = "ERROR";
                //this.titlelbl.ForeColor = Color.Red;
                this.htmlTextBX.Text = b.getHtmlContent();
            }
        }
        //Performs the get request of the history URL when clicked and displays the html content 
        private void hview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hview.Clear();
            string firstSelectedItemUrl = "";

            if (hview.SelectedItems.Count > 0)
            {
              firstSelectedItemUrl = hview.SelectedItems[0].SubItems[0].Text;

               //this.urltextbox.Text = firstSelectedItemUrl;

                Console.WriteLine("url=" + firstSelectedItemUrl);
                this.b.callRequest(firstSelectedItemUrl);
                this.connect(firstSelectedItemUrl);
 
            }
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
