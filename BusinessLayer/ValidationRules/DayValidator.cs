using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DayValidator:AbstractValidator<Day>
    {
        public DayValidator()
        {
            // Not Empty
            RuleFor(ba => ba.DayTaskContent).NotEmpty().WithMessage("Günlük Görev Boş Geçilemez");
            RuleFor(ba => ba.DayTime).NotEmpty().WithMessage("Gün Zaman Değeri Boş Geçilmez");
            RuleFor(ba => ba.UserID).NotEmpty().WithMessage("Boş Geçilmez");
            RuleFor(ba => ba.TaskImportanceID).NotEmpty().WithMessage("Boş Geçilmez");
            RuleFor(ba => ba.TaskStatuseID).NotEmpty().WithMessage("Boş Geçilmez");

            // Min 
            RuleFor(ba => ba.DayTaskContent).MinimumLength(2).WithMessage("2'den fazla değer giriniz");

            //Max
            RuleFor(ba => ba.DayTaskContent).MaximumLength(50).WithMessage("50 karakterden fazla değer girmeyiniz");
            


        }
    }
}
