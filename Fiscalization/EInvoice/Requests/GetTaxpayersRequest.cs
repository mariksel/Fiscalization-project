using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class GetTaxpayersRequest
    {
        internal GetTaxpayersRequest(DateTime sendDateTime, TaxpayerFilter filter)
        {
            Header = new GetTaxpayersRequestHeader
            {
                UUID = Guid.NewGuid().ToString(),
                SendDateTime = EInvoiceService.GetDateTime(sendDateTime)
            };
            Filter = filter;
        }
        public GetTaxpayersRequestHeader Header { get; }
        public TaxpayerFilter Filter { get; }
    }

    public class GetTaxpayersByNameRequest : GetTaxpayersRequest
    {
        public GetTaxpayersByNameRequest(DateTime sendDateTime, string name) : base(sendDateTime, new TaxpayerFilter())
        {
            Filter.ItemElementName = TaxpayerFilterItemChoice.Name;
            Filter.Item = name;
        }
    }

    public class GetTaxpayersByTinRequest : GetTaxpayersRequest
    {
        public GetTaxpayersByTinRequest(DateTime sendDateTime, string tin) : base(sendDateTime, new TaxpayerFilter())
        {
            Filter.ItemElementName = TaxpayerFilterItemChoice.Tin;
            Filter.Item = tin;
        }
    }
}
