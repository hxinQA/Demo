using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipCalculatorDataAccessLayer.Model
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CurrencyId { get; set; }
        public Double TipPercentage{get; set;}
        public Currency Currency { get; set; }
    }
}
