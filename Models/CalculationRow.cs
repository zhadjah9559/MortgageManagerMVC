using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortgageManager.Models
{
    public class CalculationRow
    {
        public int Id { get; set; }                        //PK
        public int CalculationTableId { get; set; }        //FK
                
        public int Month { get; set; }
        public decimal Payment { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal Balance { get; set; }
        
    }
}
