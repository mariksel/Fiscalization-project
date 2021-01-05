using AutoMapper;
using Fiscalization.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using SOAP = FiscalizationService.SOAP;
using RegisterInvoiceRequest = Fiscalization.Requests.RegisterInvoiceRequest;
using Fiscalization.Models;
using Fiscalization.Models.DTOs;

namespace Fiscalization.AutoMapper
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<RegisterInvoiceRequest, SOAP.RegisterInvoiceRequest>();
            CreateMap<RegisterInvoiceRequestHeader, SOAP.RegisterInvoiceRequestHeaderType>();
            CreateMap<Invoice, SOAP.InvoiceType>();
            CreateMap<InvoiceItem, SOAP.InvoiceItemType>();
            CreateMap<Seller, SOAP.SellerType>();
            CreateMap<Buyer, SOAP.BuyerType>();
            CreateMap<BadDebtInv, SOAP.BadDebtInvType>();
            CreateMap<ConsTax, SOAP.ConsTaxType>();
            CreateMap<CorrectiveInvoice, SOAP.CorrectiveInvType>();
            CreateMap<Currency, SOAP.CurrencyType>();
            CreateMap<Fee, SOAP.FeeType>();
            CreateMap<PayMethod, SOAP.PayMethodType>();
            //CreateMap<PayMethod, SOAP.PayMethodType>().As<PayMethodTypeDTO>();
            CreateMap<SumInvIICRef, SOAP.SumInvIICRefType>();
            CreateMap<SupplyDateOrPeriod, SOAP.SupplyDateOrPeriodType>();
            CreateMap<Voucher, SOAP.VoucherType>();
            CreateMap<VoucherSoldData, SOAP.VoucherSoldDataType>();
            CreateMap<VouchersSold, SOAP.VouchersSoldType>();
        }
    }
}
