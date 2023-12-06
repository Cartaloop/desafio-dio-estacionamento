using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Utilitaries
{
    public class PaymentRule
    {
        /// <summary>
        /// A method that contains the rule of payment
        /// </summary>
        /// <param name="hours">set an integer value defined by the hours spended at the parking</param>
        /// <param name="pricePerHour"></param>
        /// <param name="initialPrice"></param>
        /// <returns></returns>
        public static double CalculateTime(int hours, double pricePerHour, double initialPrice)
        {
            double calcule = (pricePerHour * hours) + initialPrice;
            return calcule;
        }
    }
}
