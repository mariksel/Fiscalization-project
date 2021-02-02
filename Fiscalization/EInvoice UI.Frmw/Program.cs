using EnumsNET;
using Fiscalization.Enums;
using Fiscalization.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EInvoice_UI.Frmw
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var test = InvoiceType.CASH.AsString();

            var services = new ServiceCollection()
           .AddSingleton<Buyer>();


            var serp = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }
}
