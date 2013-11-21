using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.DataContracts
{
    public enum PriceCodeType
    {
        Regular,
        Childrens,
        NewRelease
    }
    public class Rental
    {
        public string MovieName { get; set; }

        public int DaysRented { get; set; }

        public PriceCodeType PriceCode { get; set; }
    }
}
