using AutoMapper;
using EInvoice.Enums;
using EInvoice.Models;
using EInvoice.Requests;
using EInvoice.Responses;
using EInvoice.SOAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.AutoMapper
{
    public class EInvoiceProfile: Profile
    {
        public EInvoiceProfile()
        {
            CreateMap<GetEInvoicesRequest, GetEinvoicesRequest>();
            CreateMap<GetEInvoicesRequestHeader, GetEinvoicesRequestHeaderType>();
            CreateMap<PartyType, PartyTypeSType>();
            CreateMap<GetEinvoicesResponse, GetEInvoicesResponse>();
            CreateMap<GetEinvoicesResponseHeaderType, GetEInvoiceResponseHeader>(); 
            CreateMap<EinvoiceType, EInvoiceModel>()
                .ForMember(m=>m.Pdf, 
                            m=>m.MapFrom(sm => sm.Pdf == null ? null: new EInvoiceModel.PDF(sm.Pdf, sm.EIC)));
            //CreateMap<SOAP.DocumentType, Enums.DocumentType>();
            CreateMap<EinvoiceStatusType, EInvoiceStatus>();
            CreateMap<EInvoiceChangeStatusRequest, EinvoiceChangeStatusRequest>(); 
            CreateMap<EInvoiceChangeStatusRequestHeader, EinvoiceChangeStatusRequestHeaderType>();
            CreateMap<EinvoiceChangeStatusResponse, EInvoiceChangeStatusResponse>();
            CreateMap<EinvoiceChangeStatusResponseHeaderType, EInvoiceChangeStatusResponseHeader>();

            CreateMap<RegisterEInvoiceRequest, RegisterEinvoiceRequest>();
            CreateMap<RegisterEInvoiceRequestHeader, RegisterEinvoiceRequestHeaderType>();
            CreateMap<RegisterEinvoiceResponse, RegisterEInvoiceResponse>();
            CreateMap<RegisterEinvoiceResponseHeaderType, RegisterEInvoiceResponseHeader>();
            CreateMap< WarningType, Warning>();
            CreateMap<EInvoiceEnvelope, EinvoiceEnvelopeType>();
            

        }
    }
}
