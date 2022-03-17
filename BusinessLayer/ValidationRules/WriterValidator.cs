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
            RuleFor(a => a.WriterName).MinimumLength(3).WithMessage("İsim en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterName).MaximumLength(20).WithMessage("İsim en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterMail).MinimumLength(3).WithMessage("İsim en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterMail).MaximumLength(20).WithMessage("Mail en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterSurname).MinimumLength(3).WithMessage("Soyisim en az 3 en fazla 20 karakter olmalı");
            RuleFor(a => a.WriterSurname).MaximumLength(50).WithMessage("Soyisim en az 3 en fazla 50 karakter olmalı");
        }

    }
}
