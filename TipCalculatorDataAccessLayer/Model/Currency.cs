using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipCalculatorDataAccessLayer.Model
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public double ExchangeRate { get; set; }
        public string Symbol { get; set; }
    }
}
