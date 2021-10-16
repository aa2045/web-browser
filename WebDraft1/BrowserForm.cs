using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebDraft1
{
    public partial class BrowserForm : Form
    {
        Browser b;
        History h;
        Favorites f;

        public BrowserForm()
        {
            InitializeComponent();
            b = new Browser(this);
            h = new History();
            f = new Favorites();


            if (b != null) //prevents race condition
            {
                this.loadHomePage();
                this.loadHistory();
                this.loadDataFavorites();               
            }
        }
        /*Loads the homepage html content on browser startup 
          and homepage web address is displayed in the label*/
        private void loadHomePage() 
        {
            string homepage = b.getHomePageData();
            sethomepagelbl.Text = homepage;
            this.urltextbox.Text = homepage;
            this.connect(homepage);
        }

        // Loads previously browsed URLs on browser startup and displays it on historylv
        private void loadHistory()
        {
            List<string> history = new List<string>();
            history = h.getHistory();
            foreach (string entry in history)
            {
                string[] arr = new string[2];
                arr[0] = entry;
                ListViewItem item = new ListViewItem(arr);
                
            }
        }
        // Loads the URLs added to favorites and displays it on favoriteslv
        private void loadDataFavorites()
        {
            Dictionary<string, string> favorites = new Dictionary<string, string>();
            favorites = f.getFavorites();
            foreach(KeyValuePair<string,string> entry in favorites)
            {
                string[] arr = new string[2];
                arr[0] = entry.Key;
                arr[1] = entry.Value;
                ListViewItem item = new ListViewItem(arr);
                favoriteslv.Items.Add(item);
            }
        }
        /*Checks whether the URL entered has "http://" added in it.
         If not it is added to the URL passed.*/
        private string validateAddress(string url)
        {
            if (!Regex.IsMatch(url, @"^https?:\/\/", RegexOptions.IgnoreCase))
                return "http://"+url;

            return "";
        }

        //GO BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string url = this.urltextbox.Text;
            string response = validateAddress(url);
            //if the condition is true the below statement is executed.
            url = response.Length > 0 ? response : url;

            // Get request of url 
                b.Navigate(url);
                this.connect(url);
            
        }
        // Displays the status code and description of the browsed URL and adds it to history
        private void connect(string url)
        {
            string statusCode = b.getStatuscode();
            string statusDescription = b.getStatusDescription();

            if (statusCode.Equals("200")) 
            {
                this.titlelbl.Text = b.getTitle();
                this.titlelbl.ForeColor = Color.Green;
                this.StatusLabel.Text = statusCode + " " + statusDescription;
                this.StatusLabel.ForeColor = Color.Green;
                this.htmlContent.Text = b.getHtmlContent();

                //add it to the history listview
                string[] arr = new string[1];
                arr[0] = url;
                ListViewItem item = new ListViewItem(arr);
                //historylv.Items.Add(item);

                h.setHistory(url);
            }
            else
            {
                Console.WriteLine(statusCode);
                this.StatusLabel.Text = statusCode + " " + statusDescription;
                this.StatusLabel.ForeColor = Color.Red;
                this.titlelbl.Text = "ERROR";
                this.titlelbl.ForeColor = Color.Red;
                this.htmlContent.Text = b.getHtmlContent();
            }
        }
        //When the name of the favorite URL is clicked, HTTP Get request is performed.
        private void favoriteslv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firstSelectedItemName = "";
            string firstSelectedItemUrl = "";

            if (favoriteslv.SelectedItems.Count > 0)
            { //Name of the URL
                firstSelectedItemName = favoriteslv.SelectedItems[0].SubItems[0].Text;
               //URL 
                firstSelectedItemUrl = favoriteslv.SelectedItems[0].SubItems[1].Text;
                this.urltextbox.Text = firstSelectedItemUrl;
               //Perfoming Get Request of the URL and displaying the status code
                this.b.Navigate(firstSelectedItemUrl);
                this.connect(firstSelectedItemUrl);
            }
        }

        // HOMEPAGE BUTTON SET
        private void button3_Click(object sender, EventArgs e)
        {
            if(!homepageAddr.Text.Equals(String.Empty))
            {
                sethomepagelbl.Text = homepageAddr.Text;
                b.setHomePage(homepageAddr.Text);
                urltextbox.Text = homepageAddr.Text;
                string url = this.urltextbox.Text;
                string response = validateAddress(url);
                url = response.Length > 0 ? response : url;

                // Get request of url 
                if (!url.Equals(String.Empty))
                {
                    b.Navigate(url);
                    this.connect(url);
                }
                homepageAddr.Clear();
            }
        }

        //ADD BUTTON 
        // Adds the name and URL inputs by User to favoriteslv
        private void addurl_Click(object sender, EventArgs e)
        {
            string name = this.nameFavorites.Text;
            string url = this.urlFavorites.Text;
            this.addToFavorites(name, url);
            nameFavorites.Clear();
            urlFavorites.Clear();
        }

        // Adds the favorites URLs and name associated to favoriteslv
        // ADD to FAVORITES BUTTON
        public void addToFavorites(string name,string url)
        {
            string addressEdited = validateAddress(url);
            url = addressEdited.Length > 0 ? addressEdited : url;

            string response = "";
            bool found = false;

            if (!name.Equals(string.Empty) && !url.Equals(string.Empty))
            {
                foreach (ListViewItem lvI in this.favoriteslv.Items)
                {
                    if (lvI.SubItems[0].Text.Equals(name) && lvI.SubItems[1].Text.Equals(url) && !found)
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    string[] arr = new string[2];
                    arr[0] = name;
                    arr[1] = url;

                    ListViewItem item = new ListViewItem(arr);
                    favoriteslv.Items.Add(item);
                    //
                    response = f.addFavoritesData(name, url);
                    // Duplicates are not added
                    if (!response.Equals("successfull"))
                    {
                        this.favoriteslbl.Text = "Duplicate Data Already Exists";
                        this.favoriteslbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.favoriteslbl.ForeColor = Color.Green;
                        this.favoriteslbl.Text = "Successfully Added";
                    }
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void deleteurl_Click(object sender, EventArgs e)
        {
            string firstSelectedItemName = "";
            string firstSelectedItemUrl = "";

            if (favoriteslv.SelectedItems.Count > 0)
            {
                firstSelectedItemName = favoriteslv.SelectedItems[0].SubItems[0].Text;
                firstSelectedItemUrl = favoriteslv.SelectedItems[0].SubItems[1].Text;

                ListView.SelectedIndexCollection indices = favoriteslv.SelectedIndices;
                if (indices.Count > 0)
                {
                    this.f.removeSelectedData(firstSelectedItemName,firstSelectedItemUrl,indices[0]);

                    if (favoriteslv.SelectedItems.Count > 0)
                    {
                        favoriteslv.SelectedItems[0].Remove();
                    }
                    favoriteslbl.ForeColor = Color.Green;
                    favoriteslbl.Text = "Deleted!";
                }

            }
        }
        //RELOAD BUTTON
        private void button2_Click(object sender, EventArgs e)
        {   //Calls the reloadPage() method of browser class and reloads the http response of the url present in urltextbox
            this.b.reloadPage(this.urltextbox.Text);
            this.connect(this.urltextbox.Text);
        }

        private void homepageAddr_TextChanged(object sender, EventArgs e)
        {

        }

        // MODIFY BUTTON
        //Modifies the name and URL at selected index
        private void button3_Click_1(object sender, EventArgs e)
        {

            string firstSelectedItemName = "";
            string firstSelectedItemUrl = "";

            if (favoriteslv.SelectedItems.Count > 0)
            {
                firstSelectedItemName = favoriteslv.SelectedItems[0].SubItems[0].Text;
                firstSelectedItemUrl = favoriteslv.SelectedItems[0].SubItems[1].Text;

                ListView.SelectedIndexCollection indices = favoriteslv.SelectedIndices;
                if (indices.Count > 0)
                {
                    string name = this.nameFavorites.Text;
                    string url = this.urlFavorites.Text;

                    string addressEdited = validateAddress(url);
                    url = addressEdited.Length > 0 ? addressEdited : url;
                    /* Calls the changeSelectedDataAtIndex() method to modify name and the URL at the selected index in favorites*/
                    this.f.changeSelectedDataAtIndex(name, url, indices[0]);

                    string response = "";
                    bool found = false;
                    //Checks the condition if the nameFavorites and urlFavorites text boxes are not empty
                    if (!name.Equals(string.Empty) && !url.Equals(string.Empty))
                    {
                        string[] arr = new string[2];
                        arr[0] = name;
                        arr[1] = url;
                        // Updated name and URL is displayed on the ListView-favoriteslv
                        ListViewItem item = new ListViewItem(arr);
                        favoriteslv.Items[indices[0]] = item;
                        favoriteslbl.ForeColor = Color.Green;
                        favoriteslbl.Text = "Modified";
                        nameFavorites.Clear();
                        urlFavorites.Clear();
                    }
                }
            }

        }


        //When the menu option Add to Favorites is clicked, form2 appears
        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavoritesForm form2 = new FavoritesForm(this);
            form2.Show();
        }

        //When the menu option hisotry is clicked, the form for history appears
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HistoryForm hform = new HistoryForm();
            hform.SetHistory(this.h,this.b);
            hform.Show();

        }

        //private void modiyFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2();
        //    form2.Show();

        //}

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
