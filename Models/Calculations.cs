using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MortgageManager.Models
{
    public class Calculations
    {
        public int Id { get; set; }              //PK
        
        public decimal LoanAmount { get; set; }        
        public decimal Term { get; set; }                
        public decimal InterestRate { get; set; }

        //Child Navigational property
        public virtual ICollection<CalculationRow> CalculationRows { get; init; } = new HashSet<CalculationRow>();
    }


    public class CalculationsValidator : AbstractValidator<Calculations>
    {
        public CalculationsValidator()
        {
            RuleFor(ct => ct.LoanAmount).NotEmpty().WithMessage("Please specify amount");
            RuleFor(ct => ct.LoanAmount).GreaterThan(0).WithMessage("Must be greater than zero");
            

            RuleFor(ct => ct.Term).NotEmpty().WithMessage("Please specify amount");
            RuleFor(ct => ct.Term).GreaterThan(0).WithMessage("Must be greater than zero");


            RuleFor(ct => ct.InterestRate).NotEmpty().WithMessage("Please specify amount");
            RuleFor(ct => ct.InterestRate).GreaterThan(0).WithMessage("Must be greater than zero");
        }
    }
}
