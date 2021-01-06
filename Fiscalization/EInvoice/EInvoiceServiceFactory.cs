using EInvoice.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Fiscalization.Models;

namespace EInvoice
{
    public class EInvoiceServiceFactory
    {
        ServiceProvider ServiceProvider { get; }
        public EInvoiceServiceFactory(string certificatePath)
        {
            var services = new ServiceCollection()
           .AddSingleton(new CertificateConfigurations { Path = certificatePath })
           .AddSingleton<EInvoiceClient>()
           .AddSingleton<EInvoiceService>()
           .AddSingleton<UBLService>()
           .AddSingleton<EInvoiceFactory>()
           .AddAutoMapper(config => {
               config.AllowNullCollections = true;
           },typeof(EInvoiceServiceFactory));

            ServiceProvider = services.BuildServiceProvider();
        }
        
        public EInvoiceService EInvoiceService => ServiceProvider.GetRequiredService<EInvoiceService>();
        public EInvoiceFactory EInvoiceFactory => ServiceProvider.GetRequiredService<EInvoiceFactory>();
        public UBLService UBLService => ServiceProvider.GetRequiredService<UBLService>();



    }
}
