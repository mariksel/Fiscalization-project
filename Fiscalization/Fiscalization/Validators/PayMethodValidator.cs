﻿using FiscalizationService.SOAP;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Validators
{
    class PayMethodValidator : AbstractValidator<PayMethodType>
    {
        public PayMethodValidator()
        {
            //RuleFor(x => x.IDNum)
            //    .NotEmpty()
            //    .MaximumLength(20);
            
        }
    }
}
