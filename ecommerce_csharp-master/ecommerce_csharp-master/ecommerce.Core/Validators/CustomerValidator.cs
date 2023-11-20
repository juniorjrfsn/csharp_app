﻿using ecommerce.Core.Models;
using FluentValidation;

namespace ecommerce.Core.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(e => e.Username)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be empty")
                .Length(3, 32)
                .WithMessage("{PropertyName} should be from 3 to 32 characters");
            
            RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be empty")
                .Length(3, 32)
                .WithMessage("{PropertyName} should be from 3 to 32 characters");
            
            RuleFor(e => e.LastName)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be empty")
                .Length(3, 32)
                .WithMessage("{PropertyName} should be from 3 to 32 characters");
            
            RuleFor(e => e.ShippingAddress)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be empty")
                .Length(4, 64)
                .WithMessage("{PropertyName} should be from 4 to 64 characters");
        }
    }
}