using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ConverterWebService {
    /// <summary>
    /// Summary description for ConverterService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ConverterService : System.Web.Services.WebService {

        [WebMethod]
        public double calculateLength(double value, string from, string to) {
            Length length = new Length();
            return length.calculateLength(value, from, to);
        }
    }
}
