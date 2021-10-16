using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebDraft1
{
    public class Favorites : Browser,IConnectivity
    {
        Dictionary<string, string> favorites;
        DataClass dataObject;
       

        public Favorites()
        {
            favorites = new Dictionary<string, string>();
            dataObject = new DataClass();
            this.getFavorites();
        }

        /*Performs the get http request of the string url passed */
        public  new void getWebRequest(string url)
        {
            callRequest(url);
        }

        /*Calls the AddXmlDocumentWithFavoritesData() method of 
         the DataClass and adds the URL and name associated to the XML file*/
        public new void setXMLData()
        {
            this.dataObject.AddXmlDocumentWithFavoritesData(name, url);
        }

        /*Fetches the URLs of the favorites elements from XML file 
         and assigns it to the dictionary favorites*/
        public new void getXMLData()
        {
            this.favorites = this.dataObject.getFavorites();
        }

        /*This method is used in the form to add name and URL to XML file and display the status of the addition */
        public string addFavoritesData(string fname, string furl)
        {
            name = fname;
            url = furl;
            this.setXMLData();
            return "successfull";
        }
        /* This method is used in the form to delete the selected URL in the ListView 
           and passes the Name, URL and index to method deleteFavoritesDictionaryData() of the DataClass 
            to delete from the XML file */
        public string removeSelectedData(string fname,string furl,int index)
        {
            this.dataObject.deleteFavoritesDictionaryData(fname, furl, index);
            return "deleted";
        }

        /* This method is used in the Form1 class to modify the selected URL in the ListView 
           and passes the Name, URL and index to method changeSelectedDataAtIndex() of the DataClass 
           to modify name, URL at the selected index in XML file */

        public string changeSelectedDataAtIndex(string fname,string furl,int index)
        {
            this.dataObject.changeXmlDocumentWithFavoritesData(fname, furl, index);
            return "Modified";
        }
        /*This method is used in Form1.cs to load favorite URLs and names */
        public Dictionary<string, string> getFavorites()
        {
            this.getXMLData();
            return favorites;
        }

    }
}
