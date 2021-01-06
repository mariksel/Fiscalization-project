using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class Code
    {
        public string listID { get; set; }
        public string listAgencyID { get; set; }
        public string listAgencyName { get; set; }
        public string listName { get; set; }
        public string listVersionID { get; set; }
        public string name { get; set; }
        public string languageID { get; set; }
        public string listURI { get; set; }
        public string listSchemeURI { get; set; }
        public string Value { get; set; }

        public CodeType ToCodeType()
        {
            return new CodeType
            {
                listID = listID,
                listAgencyID = listAgencyID,
                listAgencyName = listAgencyName,
                listName = listName,
                listVersionID = listVersionID,
                name = name,
                languageID = languageID,
                listURI = listURI,
                listSchemeURI = listSchemeURI,
                Value = Value
            };
        }
    }
}
