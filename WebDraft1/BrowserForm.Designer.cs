using System;

namespace WebDraft1
{
    partial class BrowserForm
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
            this.htmlContent = new System.Windows.Forms.RichTextBox();
            this.urltextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhttpaddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusCode = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.lblhomepage = new System.Windows.Forms.Label();
            this.lblfavorites = new System.Windows.Forms.Label();
            this.nameFavorites = new System.Windows.Forms.TextBox();
            this.homepageAddr = new System.Windows.Forms.TextBox();
            this.urlFavorites = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblurl = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.homepagebtn = new System.Windows.Forms.Button();
            this.addurl = new System.Windows.Forms.Button();
            this.favoriteslv = new System.Windows.Forms.ListView();
            this.URLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URLlink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.titlelbl = new System.Windows.Forms.Label();
            this.deleteurl = new System.Windows.Forms.Button();
            this.sethomepagelbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteslbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlContent
            // 
            this.htmlContent.Location = new System.Drawing.Point(23, 80);
            this.htmlContent.Name = "htmlContent";
            this.htmlContent.Size = new System.Drawing.Size(470, 123);
            this.htmlContent.TabIndex = 0;
            this.htmlContent.Text = "";
            this.htmlContent.TextChanged += new System.EventHandler(this.htmlContent_TextChanged);
            // 
            // urltextbox
            // 
            this.urltextbox.Location = new System.Drawing.Point(126, 47);
            this.urltextbox.Name = "urltextbox";
            this.urltextbox.Size = new System.Drawing.Size(475, 22);
            this.urltextbox.TabIndex = 1;
            this.urltextbox.TextChanged += new System.EventHandler(this.urltextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblhttpaddress
            // 
            this.lblhttpaddress.AutoSize = true;
            this.lblhttpaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhttpaddress.Location = new System.Drawing.Point(18, 47);
            this.lblhttpaddress.Name = "lblhttpaddress";
            this.lblhttpaddress.Size = new System.Drawing.Size(102, 17);
            this.lblhttpaddress.TabIndex = 3;
            this.lblhttpaddress.Text = "Http Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Web Browser";
            // 
            // lblStatusCode
            // 
            this.lblStatusCode.AutoSize = true;
            this.lblStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCode.Location = new System.Drawing.Point(544, 99);
            this.lblStatusCode.Name = "lblStatusCode";
            this.lblStatusCode.Size = new System.Drawing.Size(101, 18);
            this.lblStatusCode.TabIndex = 5;
            this.lblStatusCode.Text = "Status Code";
            this.lblStatusCode.Click += new System.EventHandler(this.label4_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(569, 136);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(46, 17);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "label5";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // lblhomepage
            // 
            this.lblhomepage.AutoSize = true;
            this.lblhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomepage.Location = new System.Drawing.Point(20, 223);
            this.lblhomepage.Name = "lblhomepage";
            this.lblhomepage.Size = new System.Drawing.Size(86, 17);
            this.lblhomepage.TabIndex = 7;
            this.lblhomepage.Text = "HomePage";
            // 
            // lblfavorites
            // 
            this.lblfavorites.AutoSize = true;
            this.lblfavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfavorites.Location = new System.Drawing.Point(20, 271);
            this.lblfavorites.Name = "lblfavorites";
            this.lblfavorites.Size = new System.Drawing.Size(75, 17);
            this.lblfavorites.TabIndex = 8;
            this.lblfavorites.Text = "Favorites";
            // 
            // nameFavorites
            // 
            this.nameFavorites.Location = new System.Drawing.Point(444, 294);
            this.nameFavorites.Name = "nameFavorites";
            this.nameFavorites.Size = new System.Drawing.Size(344, 22);
            this.nameFavorites.TabIndex = 10;
            // 
            // homepageAddr
            // 
            this.homepageAddr.Location = new System.Drawing.Point(116, 218);
            this.homepageAddr.Name = "homepageAddr";
            this.homepageAddr.Size = new System.Drawing.Size(547, 22);
            this.homepageAddr.TabIndex = 11;
            this.homepageAddr.TextChanged += new System.EventHandler(this.homepageAddr_TextChanged);
            // 
            // urlFavorites
            // 
            this.urlFavorites.Location = new System.Drawing.Point(444, 358);
            this.urlFavorites.Name = "urlFavorites";
            this.urlFavorites.Size = new System.Drawing.Size(345, 22);
            this.urlFavorites.TabIndex = 12;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(385, 298);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 17);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurl.Location = new System.Drawing.Point(385, 363);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(39, 17);
            this.lblurl.TabIndex = 14;
            this.lblurl.Text = "URL";
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(607, 43);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(77, 31);
            this.go.TabIndex = 15;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // homepagebtn
            // 
            this.homepagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagebtn.Location = new System.Drawing.Point(690, 209);
            this.homepagebtn.Name = "homepagebtn";
            this.homepagebtn.Size = new System.Drawing.Size(77, 31);
            this.homepagebtn.TabIndex = 17;
            this.homepagebtn.Text = "Set";
            this.homepagebtn.UseVisualStyleBackColor = true;
            this.homepagebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // addurl
            // 
            this.addurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addurl.Location = new System.Drawing.Point(389, 398);
            this.addurl.Name = "addurl";
            this.addurl.Size = new System.Drawing.Size(121, 31);
            this.addurl.TabIndex = 18;
            this.addurl.Text = "ADD";
            this.addurl.UseVisualStyleBackColor = true;
            this.addurl.Click += new System.EventHandler(this.addurl_Click);
            // 
            // favoriteslv
            // 
            this.favoriteslv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URLName,
            this.URLlink});
            this.favoriteslv.HideSelection = false;
            this.favoriteslv.HoverSelection = true;
            this.favoriteslv.Location = new System.Drawing.Point(21, 291);
            this.favoriteslv.Name = "favoriteslv";
            this.favoriteslv.Size = new System.Drawing.Size(358, 215);
            this.favoriteslv.TabIndex = 19;
            this.favoriteslv.UseCompatibleStateImageBehavior = false;
            this.favoriteslv.View = System.Windows.Forms.View.Details;
            this.favoriteslv.SelectedIndexChanged += new System.EventHandler(this.favoriteslv_SelectedIndexChanged);
            // 
            // URLName
            // 
            this.URLName.Text = "Name";
            // 
            // URLlink
            // 
            this.URLlink.Text = "URL";
            this.URLlink.Width = 200;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(480, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(40, 17);
            this.title.TabIndex = 20;
            this.title.Text = "Title";
            this.title.Click += new System.EventHandler(this.label5_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Location = new System.Drawing.Point(544, 14);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(54, 17);
            this.titlelbl.TabIndex = 21;
            this.titlelbl.Text = "label11";
            // 
            // deleteurl
            // 
            this.deleteurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteurl.Location = new System.Drawing.Point(537, 398);
            this.deleteurl.Name = "deleteurl";
            this.deleteurl.Size = new System.Drawing.Size(119, 29);
            this.deleteurl.TabIndex = 22;
            this.deleteurl.Text = "DELETE";
            this.deleteurl.UseVisualStyleBackColor = true;
            this.deleteurl.Click += new System.EventHandler(this.deleteurl_Click);
            // 
            // sethomepagelbl
            // 
            this.sethomepagelbl.AutoSize = true;
            this.sethomepagelbl.Location = new System.Drawing.Point(113, 254);
            this.sethomepagelbl.Name = "sethomepagelbl";
            this.sethomepagelbl.Size = new System.Drawing.Size(46, 17);
            this.sethomepagelbl.TabIndex = 23;
            this.sethomepagelbl.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.favoritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem});
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            this.favoritesToolStripMenuItem.Click += new System.EventHandler(this.favoritesToolStripMenuItem_Click);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.addToFavoritesToolStripMenuItem.Text = "Add to favorites...";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // favoriteslbl
            // 
            this.favoriteslbl.AutoSize = true;
            this.favoriteslbl.Location = new System.Drawing.Point(441, 271);
            this.favoriteslbl.Name = "favoriteslbl";
            this.favoriteslbl.Size = new System.Drawing.Size(0, 17);
            this.favoriteslbl.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(678, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 26;
            this.button3.Text = "MODIFY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 494);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.favoriteslbl);
            this.Controls.Add(this.sethomepagelbl);
            this.Controls.Add(this.deleteurl);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.favoriteslv);
            this.Controls.Add(this.addurl);
            this.Controls.Add(this.homepagebtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.go);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.urlFavorites);
            this.Controls.Add(this.homepageAddr);
            this.Controls.Add(this.nameFavorites);
            this.Controls.Add(this.lblfavorites);
            this.Controls.Add(this.lblhomepage);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.lblStatusCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhttpaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urltextbox);
            this.Controls.Add(this.htmlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BrowserForm";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void urltextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void htmlContent_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.RichTextBox htmlContent;
        private System.Windows.Forms.TextBox urltextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhttpaddress;
        private System.Windows.Forms.Label lblStatusCode;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label lblhomepage;
        private System.Windows.Forms.Label lblfavorites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameFavorites;
        private System.Windows.Forms.TextBox homepageAddr;
        private System.Windows.Forms.TextBox urlFavorites;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button homepagebtn;
        private System.Windows.Forms.Button addurl;
        private System.Windows.Forms.ListView favoriteslv;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button deleteurl;
        private System.Windows.Forms.ColumnHeader URLName;
        private System.Windows.Forms.ColumnHeader URLlink;
        private System.Windows.Forms.Label sethomepagelbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.Label favoriteslbl;
        private System.Windows.Forms.Button button3;
    }
}

