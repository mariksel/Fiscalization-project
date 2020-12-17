using System;

namespace LibraryConlose
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var service1 = new SharedLibrary.EInvoiceService();
            var response1 = await service1.GetTaxPayers("Elton", EInvoice.ItemChoiceType1.Name);
        }
    }
}
