using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using System.Reflection;

namespace WebDraft1
{
    public class Browser : IConnectivity
    {
        public string html = string.Empty;
        public string statusCode = string.Empty;
        public string statusDescription = string.Empty;
        public string title = string.Empty;
        private DataClass dataObject; //instance of the DataClass

        public string homepageURL {get; set;} //public property to get and set homepageURL
        public string url { get; set; } //public property to get and set url
        public string name { get; set; } //public property to get and set the name associated for the URL (mainly used in favorites)
        public Form form;                //Object of Form form is created

       // Delegate 
        public delegate void navigateGo(string url);
        public navigateGo reload ;
        public navigateGo navigate ;

        //Performs the Get Http Request. 
        public void Navigate(string url)
        {
            navigate = new navigateGo(getWebRequest);
            navigate(url);

        }

        public Browser()
        {
            dataObject = new DataClass();
            this.loadDataOnForm();
        }

        //Parameterised Constructor
        public Browser(Form form) 
        {
            if(dataObject == null) 
                dataObject = new DataClass();

            this.form = form;
            this.loadDataOnForm();
        }

        // Returns the Title of the web address requested
        public string getTitle()
        {
            return title;
        }

        /*This method fetches the homepage URL from the XML file 
          and performs the Get http request of the URL */
        public void loadDataOnForm()
        {
            this.getXMLData();
            this.Navigate(this.homepageURL);
        }

        /*This method assigns the homepage URL stored in the XML file 
          to variable homepageURL */
        public void getXMLData()
        {
            this.homepageURL = this.dataObject.getHomePageURL();
        }
        
        /*This method returns the homepage URL and is used in the form class */
        public string getHomePageData()
        {
            return this.homepageURL;
        }

        /*Sets the new URL as homepage 
       and setXMLData() method is called to update the homepage URL in XML file */
        public string setHomePage(string newurl)
        {
            this.homepageURL = newurl;
            this.setXMLData();
            return "homepage added";
        }

        /* setXMLData() calls the setHomePage() method in DataClass
           to update the homepage URL in XML file */
        public void setXMLData()
        {
            this.dataObject.setHomePage(this.homepageURL);
        }

        /*Delegate implemented 
         * This method performs the Get http request of the url passed. (For Reload button)*/
        public void reloadPage(string url)
        {
            reload = new navigateGo(getWebRequest);
            reload(url);
        }

        //Returns the status description of the URL
        public string getStatusDescription()
        {
            return statusDescription;
        }
        
        //Returns the status code of the URL
        public string getStatuscode()
        {
            return statusCode;
        }

        //Returns the raw html content of the URL
        public string getHtmlContent()
        {
            return html;
        }

        /*This method calls the method getWebRequest() of the URL passed. 
          callRequest() method is called in Favorites class, History class and Form1 class  */
        public void callRequest(string url)
        {
            getWebRequest(url);
        }

        //Performs the GET request of URL passed 
        public void getWebRequest(string url)
        {
            try
            {   // Create a request for the URL
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                // Get the response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {  // Display the status
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        statusCode = "200";
                        statusDescription = response.StatusDescription;
                    }
                    //The stream containing response data sent by the server
                    using (Stream stream = response.GetResponseStream())
                    // Open the stream using a StreamReader for easy access
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        Console.WriteLine(stream);
                        // Read the content
                        html = reader.ReadToEnd();
                        //Regular expressions used to get the title of the URL requested
                        title = Regex.Match(html, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
            RegexOptions.IgnoreCase).Groups["Title"].Value;  
                    }
                }

            }
              // Get the associated response for an invalid request.
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.Unauthorized)
                    {
                        statusCode = "401";
                        html = ex.Message;
                        Console.WriteLine(statusCode);
                        statusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                    }

                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound)
                    {
                        statusCode = "404";
                        html = ex.Message;
                        Console.WriteLine(statusCode);
                        statusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                    }
                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.BadRequest)
                    {
                        statusCode = "400";
                        html = ex.Message;
                        Console.WriteLine(statusCode);
                        statusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                    }
                    if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.Forbidden)
                    {
                        statusCode = "403";
                        html = ex.Message;
                        Console.WriteLine(statusCode);
                        statusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                    }
                }
                else if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    // handle name resolution failure
                    statusCode = "Name Resolution Failure";
                    html = ex.Message;
                    Console.WriteLine(((HttpWebResponse)ex.Response));
                    //statusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                }
                else
                {
                    Console.WriteLine("some other issue");
                }
            }
        }

    }
    }

