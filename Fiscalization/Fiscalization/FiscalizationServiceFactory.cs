using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Fiscalization.Models;

namespace Fiscalization
{
    public class FiscalizationFactory
    {
        ServiceProvider ServiceProvider { get; }
        public FiscalizationFactory(string certificatePath)
        {
            var services = new ServiceCollection()
           .AddSingleton(new CertificateConfigurations { Path = certificatePath })
           .AddSingleton<FiscalizationClient>()
           .AddSingleton<FiscalizationService>()
           .AddScoped<IFisXmlSignerEndpointBehavior, FisXMLSignerEndpointBehavior>()
           .AddAutoMapper(config => {
               config.AllowNullCollections = true;
           }, typeof(FiscalizationFactory));

            ServiceProvider = services.BuildServiceProvider();
        }
        
        public FiscalizationService GetFiscaliztionService()
        {
            return ServiceProvider.GetRequiredService<FiscalizationService>();
        }
    }
}
