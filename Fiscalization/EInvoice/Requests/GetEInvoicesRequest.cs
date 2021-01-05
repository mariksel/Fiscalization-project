using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using EnumsNET;

namespace EInvoice.Requests
{
    public class GetEInvoicesRequest
    {
        public static GetEInvoicesRequest GetEInvoiceByEICRequest(string eic, DateTime? sendDateTime = null)
            => new GetEInvoicesRequest(sendDateTime)
            {
                EIC = eic
            };

        public static GetEInvoicesRequest GetEInvoicesListRequest(PartyType? partyType = null, DateTime? from = null, DateTime? to = null, DateTime? sendDateTime = null)
        {
            var request = new GetEInvoicesRequest(sendDateTime);
            if (partyType.HasValue)
                request.PartyType = partyType.Value;
            if (from.HasValue)
                request.RecDateTimeFrom = from.Value;
            if (to.HasValue)
                request.RecDateTimeTo = to.Value;

            return request;
        }
            

        private GetEInvoicesRequest(DateTime? sendDateTime = null) {
            sendDateTime = sendDateTime ?? DateTime.Now;
            Header = new GetEInvoicesRequestHeader
            {
                SendDateTime = EInvoiceService.GetDateTime( sendDateTime.Value),
                UUID = Guid.NewGuid().ToString()
            };
        }
        public GetEInvoicesRequestHeader Header { get; set; }
        public string EIC { get; set; }

        public bool PartyTypeSpecified { get; private set; } = false;
        private PartyType _partyType;
        public PartyType PartyType { 
            get => _partyType;
            set
            {
                if(value.IsDefined())
                {
                    _partyType = value;
                    PartyTypeSpecified = true;
                }
            }
        }

        public bool RecDateTimeFromSpecified { get; private set; } = false;
        private DateTime _recDateTimeFrom;
        /// <summary>Filter Forom Date</summary>
        public DateTime RecDateTimeFrom { 
            get => _recDateTimeFrom;
            set {
                _recDateTimeFrom = value;
                RecDateTimeFromSpecified = true;
            } 
        }

        public bool RecDateTimeToSpecified { get; private set; } = false;
        private DateTime _recDateTimeTo;
        /// <summary>Filter To Date</summary>
        public DateTime RecDateTimeTo { 
            get => _recDateTimeTo;
            set
            {
                _recDateTimeTo = value;
                RecDateTimeToSpecified = true;
            }
        }

    }
}
