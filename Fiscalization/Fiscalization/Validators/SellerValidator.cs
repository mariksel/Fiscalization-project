using Fiscalization.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Validators
{
    public class SellerValidator : AbstractValidator<Seller>
    {
        public SellerValidator()
        {
            RuleFor(x => x.IDNum)
                .NotEmpty()
                .MaximumLength(20);
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
