using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization
{
    class FiscalizationClient : FiscalizationServicePortTypeClient
    {
        public FiscalizationClient()
        {
            var endpointBehavior = new XMLSignerEndpointBehavior();
            Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }
    }
}
