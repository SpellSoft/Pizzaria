using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model.Utilities
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class CompareValue : ValidationAttribute
    {
        public double Property { get; set; }
        public CompareValue(object property,string message) : base(message)
        {
            this.Property = (double)property;
        }
        public override bool IsValid(object value)
        {

            return base.IsValid(value);
        }
    }
}
