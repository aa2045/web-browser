using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Http;

namespace WebDraft1
{
    public class DataClass
    {
        private string homePageURL { get; set; }
        private Dictionary<string, string> favorites { get; set; }
        private List<string> history { get; set; }
        private XmlDocument xmlDoc;

        public DataClass()
        {
            this.loadFavoritesData();
            this.loadHomePageData();
            this.loadHistoryData();
        }
        /*This methods add history URLs to the XML and saves it.
         XML tree- elementHistoryUrl contains history URL and is appended to history element*/
        public void AddXmlDocumentWithHistoryData(string hurl)
        {
            XDocument xDoc = XDocument.Load("test-doc.xml");
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");

           foreach (XElement xEle in rows)
            {
                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "history");

                XElement elementHistoryUrl = new XElement("url", hurl);
                xDoc.Descendants("history").First().Add(elementHistoryUrl);
            }

            xDoc.Save("test-doc.xml");
        }
  
        public string addFavoritesData(string fname, string furl)
        {
            string response = "";
            // Add favorites Data
            try
            {
                foreach(KeyValuePair<string,string> k in this.favorites)
                {
                   if(!fname.Equals(k.Key) && !furl.Equals(k.Value))
                    {
                        this.favorites.Add(fname.ToString(), furl.ToString());
                        this.AddXmlDocumentWithFavoritesData(fname, furl);
                        response = "successfull";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                response = ex.Message;
            }

            return response;
        }
        
        /*This method adds the URLs and name associated to the XML file */
        public void AddXmlDocumentWithFavoritesData(string fname,string furl)
        {
            XDocument xDoc = XDocument.Load("test-doc.xml");
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");
            IEnumerable<XElement> frows = xDoc.Descendants().Where(d => d.Name == "favorites");
            //elementUrlGroup is populated with name and url  and is added to the element favorites
            XElement elementUrlGroup = new XElement("urlgroup", "");
            xDoc.Descendants("favorites").First().Add(elementUrlGroup);
            elementUrlGroup.Add(new XElement("name", fname));
            elementUrlGroup.Add(new XElement("url", furl));

            string newXml = xDoc.ToString();

            xDoc.Save("test-doc.xml");

        }

        public void addHistoryData(string hurl)
        {
            // Add history Data
            this.history.Add(hurl);
           this.AddXmlDocumentWithHistoryData(hurl);
        }

        public void deleteFavoritesDictionaryData(string name,string url, int index)
        {
            this.deleteDocumentWithFavoritesData(name, url,index);
        }
        

        //deleting the selected Name-URL pair from XML file
        public void deleteDocumentWithFavoritesData(string fname, string furl, int nindex)
        {
            try
            {
                XDocument xDoc = XDocument.Load("test-doc.xml");
                IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");

                foreach (XElement xEle in rows)
                {
                    var linksParser = new Regex(@"(?i)(http(s)?:\/\/)(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)", RegexOptions.Singleline);

                    IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "favorites");
                    IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "urlgroup");

                    int counter = 0;
                    try
                    {
                        foreach (XElement gelemnt in grows)
                        {
                            var favoritesDictionary = gelemnt.Value;
                            var name = "";
                            var url = "";

                            foreach (Match m in linksParser.Matches(favoritesDictionary))
                            {
                                url = m.ToString();
                                int index = favoritesDictionary.IndexOf(url);
                                name = favoritesDictionary.Remove(index);

                            }

                            if (url.Equals(furl) && fname.Equals(name) && (nindex == counter))
                            {
                                gelemnt.Remove();
                                xDoc.Save("test-doc.xml");
                                break;
                            }

                            counter += 1;

                        
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Modifying the XML file with the changes made in Name of URL
        public void changeXmlDocumentWithFavoritesData(string fname,string furl,int nindex)
        {
            XDocument xDoc = XDocument.Load("test-doc.xml");
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");

            foreach (XElement xEle in rows)
            {     //Regular expressions for the URL address
                var linksParser = new Regex(@"(?i)(http(s)?:\/\/)(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)", RegexOptions.Singleline);
                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "favorites");
                IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "urlgroup");
                int counter = 0;
                foreach (XElement gelemnt in grows)
                {
                    var favoritesDictionary = gelemnt.Value;
                    
                    //Retrieval of matches-
                    foreach (Match m in linksParser.Matches(favoritesDictionary))
                    {
                        var url = m.ToString();
                        int index = favoritesDictionary.IndexOf(url);
                        var name = favoritesDictionary.Remove(index);

                      //updating the modified URL and name to the XML file 
                        if(nindex == counter)
                        { var fUname = fname + " " + furl; 
                            gelemnt.Value = fUname;
                            xDoc.Save("test-doc.xml");
                            Console.WriteLine("updated xml document");
                            break;
                        }
                        counter += 1;
                    }

                    
                }

            }

        }

     /*This method loads the homepage data on the startup of the browser*/
        public void loadHomePageData()
        {
            Console.WriteLine("loading HomePage Data.....");
            //file is loaded
            XDocument xDoc = XDocument.Load("test-doc.xml");
            
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");

            foreach (XElement xEle in rows)
            {   //This query uses lambda expression to retrive the textHomePageUrl appended in the element url.
                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "hompage");
                IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "url");
                //Execute the query
                foreach (XElement xelement in grows)
                {
                     Console.WriteLine(xEle);
                    //homepage url is assigned to the variable homePageURL
                    this.homePageURL = xelement.Value;
                    Console.WriteLine(this.homePageURL);
                }
            }
        }
        //method used in Browser class
        //updates the new homepage URL in XML file
        public void setHomePage(string homepageURL)
        {
            //update the new homepage URL to the XML file
            XDocument xDoc = XDocument.Load("test-doc.xml");
            // lamda expression to return the collection of descendants elements of browser
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");
            //This query is to update homepage URL to a given URL
            foreach (XElement xEle in rows)
            {
                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "hompage");
                IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "url");
                // execute query and the value is updated
                foreach (XElement xelement in grows)
                {
                    xelement.Value = homepageURL;
                }
            }

            Console.WriteLine(xDoc);
            xDoc.Save("test-doc.xml");

        }

        //This method loads the history data
        public List<string> loadHistoryData()
        { 
            this.history = new List<string>();
            XDocument xDoc = XDocument.Load("test-doc.xml");
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");
            //LINQ query  is used to retrive the list of history URLs
            foreach (XElement xEle in rows)
            {
                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "history");
                IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "url");
                //Query Execution
                foreach (XElement gelemnt in grows)
                {
                    var historyURL = gelemnt.Value;
                    var url = historyURL;
                    //URLs is added to the list
                    this.history.Add(url);
                }
            }

            return this.history;
        }

        /*This method loads the favorites URLs on browser startup*/
        public void loadFavoritesData()
        {
            Console.WriteLine("loading favorites Data");
            this.favorites = new Dictionary<string, string>();
            XDocument xDoc = XDocument.Load("test-doc.xml");
           
            IEnumerable<XElement> rows = xDoc.Descendants().Where(d => d.Name == "browser");

            foreach (XElement xEle in rows)
            {
                var linksParser = new Regex(@"(?i)(http(s)?:\/\/)(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)", RegexOptions.Singleline);

                IEnumerable<XElement> frows = xEle.Descendants().Where(d => d.Name == "favorites");
                IEnumerable<XElement> grows = frows.Descendants().Where(d => d.Name == "urlgroup");

                foreach(XElement gelemnt in grows)
                {
                    var favoritesDictionary = gelemnt.Value;
                    var name = "";
                    var url = "";

                    foreach(Match m in linksParser.Matches(favoritesDictionary))
                    {
                        url = m.ToString();
                        int index = favoritesDictionary.IndexOf(url);
                        name = favoritesDictionary.Remove(index);
                        try
                        {
                            this.favorites.Add(name.ToString(), url.ToString());
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
            }          
        }

//returns dictionary of favorites
        public Dictionary<string,string> getFavorites()
        {
            this.loadFavoritesData();
            return favorites;
        }
// returns a list of history URLS
        public List<String> getHistory()
        {
            this.loadHistoryData();
            return history;
        }
// returns the homepage URL to be loaded
        public string getHomePageURL()
        {

            this.loadHomePageData();
            return homePageURL;
        }

       

       
    }
}
