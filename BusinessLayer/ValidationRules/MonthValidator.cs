using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MonthValidator:AbstractValidator<Month>
    {
        public MonthValidator()
        {
            //Not Empty
            RuleFor(ba => ba.MonthTaskContent).NotEmpty().WithMessage("Aylık Görevi Boş Geçmeyiniz Lütfen");
            RuleFor(ba => ba.MonthTime).NotEmpty().WithMessage("Boş Geçmeyiniz Lütfen");
            RuleFor(ba => ba.TaskImportanceID).NotEmpty().WithMessage("Boş Geçmeyiniz Lütfen");
            RuleFor(ba => ba.TaskStatuseID).NotEmpty().WithMessage("Boş Geçmeyiniz Lütfen");
            RuleFor(ba => ba.UserID).NotEmpty().WithMessage("Boş Geçmeyiniz Lütfen");

            // Minimum
            RuleFor(ba => ba.MonthTaskContent).MinimumLength(3).WithMessage("3 Karakterden daha uzun veri girişini giriniz");

            //Maximum
            RuleFor(ba => ba.MonthTaskContent).MaximumLength(50).WithMessage("50 Karakterden uzun olmasın");

        }
    }
}
