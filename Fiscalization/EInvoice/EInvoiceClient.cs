
using EInvoice.SOAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice
{
    public class EInvoiceClient : EinvoiceServicePortTypeClient
    {
        public EInvoiceClient()
        {
            var endpointBehavior = new XMLSignerEndpointBehavior();
            Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }
    }
}
