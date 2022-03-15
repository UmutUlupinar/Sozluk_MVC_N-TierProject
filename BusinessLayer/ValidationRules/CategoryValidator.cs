using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
             RuleFor(a=>a.CategoryName).NotEmpty().WithMessage("Kategori Adını doldurunuz");
             RuleFor(a => a.CategoryDescription).NotEmpty().WithMessage("Açıklama giriniz");
            RuleFor(a => a.CategoryName).MinimumLength(3).WithMessage("en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.CategoryName).MaximumLength(20).WithMessage("en az 3 en fazla 20 karakter olmalı");
        }

    }
}
