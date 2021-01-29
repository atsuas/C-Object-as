using System;
namespace C_Object
{
    public class Money
    {
        public Money(decimal value)
        {
            Value = Value;
        }

        public decimal Value { get; }

        public decimal TaxValue
        {
            get
            {
                return Value * 1.08m;
            }
        }
    }
}
