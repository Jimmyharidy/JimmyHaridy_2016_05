using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace JimmyHaridy_MVC_2016_05.Models.Attributes
{
    public class ExtraSafeValidation: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var input = value.ToString().ToLower();
            if (input.StartsWith("p-"))
                return true;
            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Please try again, product number must start with p followed with -, ex: p-999";
        }
    }
}