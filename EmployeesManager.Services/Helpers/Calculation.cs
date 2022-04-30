using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Services.Helpers
{
    public class Calculator
    {
        public static decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Div(decimal a, decimal b)
        {
            return a/b;
        }

        public static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }

    public class PremiumCalculator
    {
        public decimal Calculate(decimal sallary, decimal rating)
        {
           return Calculator.Mul(rating, Calculator.Div(sallary, 100));             
        }
    }

    public static class PaymentsCalculator
    {
        public static decimal Calculate(decimal sallary, decimal rating)
        {
            PremiumCalculator calculator = new PremiumCalculator();
            var premium = calculator.Calculate(sallary, rating);
            return Calculator.Sum(sallary, premium);
        }
    }
}
