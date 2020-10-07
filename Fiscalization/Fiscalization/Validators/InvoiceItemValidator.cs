using Fiscalization.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Validators
{
    class InvoiceItemValidator : AbstractValidator<InvoiceItem>
    {
        public InvoiceItemValidator()
        {
            RuleFor(x => x.N)
                .NotEmpty()
                .MaximumLength(50);

        }
    }
}
