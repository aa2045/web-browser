using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDraft1
{
    interface IConnectivity
    {
        void getWebRequest(string url);
        void getXMLData();
        void setXMLData();
    }
}
