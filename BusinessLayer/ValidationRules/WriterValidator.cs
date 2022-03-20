using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(a => a.WriterName).NotEmpty().WithMessage("Kategori Adını doldurunuz");
            RuleFor(a => a.WriterSurname).NotEmpty().WithMessage("Açıklama giriniz");
            RuleFor(a => a.WriterAbout).NotEmpty().WithMessage("Hakkında bilgisi giriniz");
            RuleFor(a => a.WriterMail).NotEmpty().WithMessage("Mail adresi giriniz");
            RuleFor(a => a.WriterTitle).NotEmpty().WithMessage("Yazar unvan bilgisi giriniz");
            RuleFor(a => a.WriterTitle).MinimumLength(2).WithMessage("İsim en az 2 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterTitle).MaximumLength(40).WithMessage("Unvan en az 2 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterName).MinimumLength(3).WithMessage("Unvan en az 3 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterName).MaximumLength(40).WithMessage("İsim en az 3 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterMail).MinimumLength(3).WithMessage("Mail en az 3 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterMail).MaximumLength(40).WithMessage("Mail en az 3 en fazla 40 karakter olmalı");
            RuleFor(a => a.WriterSurname).MinimumLength(3).WithMessage("Soyisim en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterSurname).MaximumLength(20).WithMessage("Soyisim en az 3 en fazla 20 karakter olmalı");
        }

    }
}
