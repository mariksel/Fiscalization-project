using AutoMapper;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fiscalization
{
    public class FiscalizationClient
    {
        private IMapper _mapper;
        FiscalizationServicePortTypeClient ClientGen { get; } = new FiscalizationServicePortTypeClient();
        public FiscalizationClient(IMapper mapper, IFisXmlSignerEndpointBehavior endpointBehavior)
        {
            _mapper = mapper;
            ClientGen.Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }

        public async Task<RegisterInvoiceResponse> RegisterInvoiceAsync(Requests.RegisterInvoiceRequest request)
        {
            var reqGen = _mapper.Map<RegisterInvoiceRequest>(request);
            return (await ClientGen.registerInvoiceAsync(reqGen)).RegisterInvoiceResponse;
        }
    }
}
