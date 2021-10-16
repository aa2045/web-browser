using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WebDraft1
{
    public class History : Browser, IConnectivity
    {
        private List<string> url;
        private DataClass dataObject;

        private string urlString;

        // Default Constructor that loads history data 
        public History()
        {
            url = new List<string>();
            dataObject = new DataClass();
            this.getHistory();
        }

        // Parameterised constructor  
        public History(string url)
        {
            this.url = new List<string>();
            this.url.Add(url);
        }

        public string setHistory(string url)
        {
            this.urlString = url;
            this.setXMLData();
            return "added to history";                
        }

        /* Returns the list of history URLs that are saved in XML file */
        public List<string> getHistory()
       {
            this.getXMLData();
            return this.url;
        }

        public new void getWebRequest(string url)
        {
            callRequest(url);
        }
        // Fetches the list of previously browsed URLs from the XML file
        public new void getXMLData()
        {
            this.url = dataObject.loadHistoryData();
        }

       /*Adds the urlString to the XML file */
        public new void setXMLData()
        {
            this.dataObject.addHistoryData(this.urlString);
        }

    }
}
