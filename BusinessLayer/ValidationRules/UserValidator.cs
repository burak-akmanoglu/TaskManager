using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        { 
            // Not Empty
            RuleFor(ba => ba.UserName).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(ba => ba.UserSurname).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(ba => ba.UserEmail).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(ba => ba.UserPassword).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            

            // Minimum 
            RuleFor(ba => ba.UserName).MinimumLength(2).WithMessage("2 Karakterden Daha Uzun Olmalı");
            RuleFor(ba => ba.UserSurname).MinimumLength(2).WithMessage("2 Karakterden Daha Uzun Olmalı");
            RuleFor(ba => ba.UserEmail).MinimumLength(6).WithMessage("6 Karakterden Daha Uzun Olmalı");
            RuleFor(ba => ba.UserPassword).MinimumLength(4).WithMessage("4 Karakterden Daha Uzun Olmalı");

            //Maximum
            RuleFor(ba => ba.UserName).MaximumLength(30).WithMessage("30 Karakter Girişinden Daha Az Olmalı");
            RuleFor(ba => ba.UserSurname).MaximumLength(30).WithMessage("30 Karakter Girişinden Daha Az Olmalı");
            RuleFor(ba => ba.UserEmail).MaximumLength(50).WithMessage("50 Karakter Girişinden Daha Az Olmalı");

            RuleFor(ba => ba.UserEmail).EmailAddress().WithMessage("Bu mail değil");

        }
    }
}
