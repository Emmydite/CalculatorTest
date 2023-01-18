using CalculatorTest.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.BLL.Services
{
    public class SimpleCalculatorService : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            try
            {
               var result = start + amount;

                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public int Subtract(int start, int amount)
        {
            try
            {
                var result = start - amount;

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
