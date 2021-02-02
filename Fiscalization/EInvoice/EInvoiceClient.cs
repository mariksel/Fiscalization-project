
using AutoMapper;
using EInvoice.Requests;
using EInvoice.Responses;
using EInvoice.SOAP;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using static EInvoice.SOAP.EinvoiceServicePortTypeClient;

namespace EInvoice
{
    public class EInvoiceClient 
    {
        EinvoiceServicePortTypeClient ClientGen;
        IMapper _mapper { get; }
        public EInvoiceClient(IMapper mapper)
        {
            _mapper = mapper;
            //string serviceAddress = "https://efiskalizimi-test.tatime.gov.al/FiscalizationService-v3";
            string serviceAddress = "https://localhost:5001/einvoice";
            ClientGen = new EinvoiceServicePortTypeClient(EndpointConfiguration.EinvoiceServicePort, serviceAddress);

            var endpointBehavior = new XMLSignerEndpointBehavior();
            ClientGen.Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }
        

        public async Task<GetEInvoicesResponse> GetEInvoicesAsync(GetEInvoicesRequest request)
        {
            var requestGen = _mapper.Map<GetEInvoicesRequest, GetEinvoicesRequest>(request);
            try
            {
                var resGen = (await ClientGen.getEinvoicesAsync(requestGen)).GetEinvoicesResponse; ;

                var res = _mapper.Map<GetEinvoicesResponse, Responses.GetEInvoicesResponse>(resGen);
                return res;
            }
            catch (FaultException ex)
            {
                return new Responses.GetEInvoicesResponse
                {
                    Success = false,
                    ErrorCode = ex.Code.Name,
                    ErrorMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new Responses.GetEInvoicesResponse
                {
                    Success = false,
                    ErrorCode = "500",
                    ErrorMessage = ex.Message
                };
            }
        }


        public async Task<Responses.GetTaxpayersResponse> GetTaxpayersAsync(Requests.GetTaxpayersRequest request)
        {
            var requestGen = _mapper.Map<Requests.GetTaxpayersRequest, SOAP.GetTaxpayersRequest>(request);
            try
            {
                var resGen = (await ClientGen.getTaxpayersAsync(requestGen)).GetTaxpayersResponse;

                var res = _mapper.Map<SOAP.GetTaxpayersResponse, Responses.GetTaxpayersResponse>(resGen);
                return res;
            }
            catch (FaultException ex)
            {
                return new Responses.GetTaxpayersResponse
                {
                    Success = false,
                    ErrorCode = ex.Code.Name,
                    ErrorMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new Responses.GetTaxpayersResponse
                {
                    Success = false,
                    ErrorCode = "500",
                    ErrorMessage = ex.Message
                };
            }
            
        }

        public async Task<EInvoiceChangeStatusResponse> EInvoiceChangeStatusAsync(EInvoiceChangeStatusRequest request)
        {
 
            var requestGen = _mapper.Map<EInvoiceChangeStatusRequest, EinvoiceChangeStatusRequest>(request);
            try
            {
                var resGen = (await ClientGen.einvoiceChangeStatusAsync(requestGen)).EinvoiceChangeStatusResponse;

                var res = _mapper.Map<EinvoiceChangeStatusResponse, EInvoiceChangeStatusResponse>(resGen);
                return res;
            }
            catch (FaultException ex)
            {
                return new EInvoiceChangeStatusResponse
                {
                    Success = false,
                    ErrorCode = ex.Code.Name,
                    ErrorMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new EInvoiceChangeStatusResponse
                {
                    Success = false,
                    ErrorCode = "500",
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<RegisterEInvoiceResponse> RegisterEInvoiceAsync(RegisterEInvoiceRequest request)
        {

            var requestGen = _mapper.Map<RegisterEInvoiceRequest, RegisterEinvoiceRequest>(request);
            try
            {
                var resGen = (await ClientGen.registerEinvoiceAsync(requestGen)).RegisterEinvoiceResponse;

                var res = _mapper.Map<RegisterEinvoiceResponse, RegisterEInvoiceResponse>(resGen);
                return res;
            }
            catch (FaultException ex)
            {
                return new RegisterEInvoiceResponse
                {
                    Success = false,
                    ErrorCode = ex.Code.Name,
                    ErrorMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new RegisterEInvoiceResponse
                {
                    Success = false,
                    ErrorCode = "500",
                    ErrorMessage = ex.Message
                };
            }
        }

    }
}
