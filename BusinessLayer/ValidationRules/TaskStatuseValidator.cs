using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class TaskStatuseValidator:AbstractValidator<TaskStatuse>
    {
        public TaskStatuseValidator()
        {
            // Not Empty
            RuleFor(ba => ba.TaskStatuseName).NotEmpty().WithMessage("Bu Alanı Boş Bırakmayınız");

            // Minimum 
            RuleFor(ba => ba.TaskStatuseName).MinimumLength(2).WithMessage("2 Karakterden Daha Uzun Olmalı");

            //Maximum
            RuleFor(ba => ba.TaskStatuseName).MaximumLength(50).WithMessage("50 Karakter Girişinden Daha Az Olmalı");

        }
    }
}
