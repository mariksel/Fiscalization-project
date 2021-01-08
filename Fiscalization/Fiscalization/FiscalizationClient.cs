using AutoMapper;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FiscalizationService.SOAP.FiscalizationServicePortTypeClient;

namespace Fiscalization
{
    public class FiscalizationClient
    {
        private IMapper _mapper;
        FiscalizationServicePortTypeClient ClientGen { get; }
        public FiscalizationClient(IMapper mapper, IFisXmlSignerEndpointBehavior endpointBehavior)
        {
            //string serviceAddress = "https://efiskalizimi-test.tatime.gov.al/FiscalizationService-v3";
            string serviceAddress = "https://localhost:5001/fiscalization";
            _mapper = mapper;
            ClientGen = new FiscalizationServicePortTypeClient(EndpointConfiguration.FiscalizationServicePort, serviceAddress);
            ClientGen.Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }

        public async Task<RegisterInvoiceResponse> RegisterInvoiceAsync(Requests.RegisterInvoiceRequest request)
        {
            var reqGen = _mapper.Map<RegisterInvoiceRequest>(request);
            return (await ClientGen.registerInvoiceAsync(reqGen)).RegisterInvoiceResponse;
        }
    }
}
