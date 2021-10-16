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
    public partial class FavoritesForm : Form
    {
        BrowserForm form1; //An object if Form1 form1 is instantiated

        public FavoritesForm()
        {
            InitializeComponent();
        }

        public FavoritesForm(BrowserForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Adds the URL and name associated to favorites
        private void addbtn_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string url = this.url.Text;

            this.form1.addToFavorites(name, url);

            this.Close();
        }

        private void modify_Click(object sender, EventArgs e)
        {

        }
    }
}
