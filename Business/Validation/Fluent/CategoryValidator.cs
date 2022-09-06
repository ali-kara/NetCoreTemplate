using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.Fluent
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.CategoryName).NotEmpty();
            RuleFor(p => p.CategoryName).MinimumLength(2);
            RuleFor(p => p.Description).MaximumLength(200).WithMessage("Kategoriler Maksimum 200 karakter olmaldıır.");
            //RuleFor(p => p.Description).GreaterThan(0);
            //RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}