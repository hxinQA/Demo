using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipCalculatorDataAccessLayer.Model
{
    public class Setting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
