using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TaskImportanceValidator:AbstractValidator<TaskImportance>
    {
        public TaskImportanceValidator()
        {
            // Not Empty
            RuleFor(ba => ba.TaskImportanceName).NotEmpty().WithMessage("Önem Değerini Giriniz");

            // Minimum 
            RuleFor(ba => ba.TaskImportanceName).MinimumLength(2).WithMessage("2 Karakterden Daha Uzun Olmalı");

            //Maximum
            RuleFor(ba => ba.TaskImportanceName).MaximumLength(50).WithMessage("50 Karakter Girişinden Daha Az Olmalı");

        }
    }
}
