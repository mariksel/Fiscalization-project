using Fiscalization.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Validators
{
    public class InvoiceValidator : AbstractValidator<Invoice>
    {
        public InvoiceValidator()
        {
            RuleFor(x => x.OperatorCode).NotEmpty();
            RuleFor(x => x.InvOrdNum).GreaterThan(0);
            RuleFor(x => x.BusinUnitCode).NotEmpty()
                .Matches(@"[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}")
                .Length(10);
            RuleFor(x => x.SoftCode).NotEmpty()
                .Matches(@"[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}")
                .Length(10);
            RuleFor(x => x.InvNum).NotEmpty()
                .Matches(@"[0-9][1-9]{0,14}\/[0-9]{4}(\/[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3})?");
            RuleFor(x => x.Seller)
                .NotNull()
                .SetValidator(new SellerValidator());
            RuleFor(x => x.PayMethods).NotNull();
            RuleForEach(x => x.PayMethods)
                .NotNull()
                .SetValidator(new PayMethodValidator());
            RuleFor(x => x.Items).NotNull();
            RuleForEach(x => x.Items)
                .NotNull()
                .SetValidator(new InvoiceItemValidator());
            RuleFor(x => x.TCRCode).NotNull().Matches("[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}");

        }
    }
}
