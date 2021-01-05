using AutoMapper;
using EInvoice.Enums;
using EInvoice.Models;
using EInvoice.Requests;
using EInvoice.SOAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.AutoMapper
{
    public class TaxpayerProfile: Profile
    {
        public TaxpayerProfile()
        {
            CreateMap<Requests.GetTaxpayersRequest, SOAP.GetTaxpayersRequest>();
            CreateMap<GetTaxpayersRequestHeader, GetTaxpayersRequestHeaderType>();
            CreateMap<TaxpayerFilter, TaxpayerFilterType>();
            CreateMap<TaxpayerFilterItemChoice, ItemChoiceType1>();
            CreateMap<GetTaxpayersResponse, Responses.GetTaxpayersResponse>();
            CreateMap<GetTaxpayersResponseHeaderType, Responses.GetTaxpayersResponseHeader>();
            CreateMap<TaxpayerType, Taxpayer>();
        }
    }
}
