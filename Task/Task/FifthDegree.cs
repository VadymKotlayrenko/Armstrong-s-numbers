using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class FifthPower
    {
        //Convert numbers into ArrayOfDigits
        private int[] ArrayOfDigits(string number)
        {
            int[] arrayOfDigits = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
                arrayOfDigits[i] = Convert.ToInt32(number[i]) - 48;

            return arrayOfDigits;
        }
        
        //Counting sum in fifth power of array elements
        private int SumFifthPower(int[] arrayOfDigits)
        {
            int number = 0;

            for (int i = 0; i < arrayOfDigits.Length; i++)
                number += (int)Math.Pow(arrayOfDigits[i], 5);

            return number;
        }

        //Cheking for Armstrong`s digit. Counting sum of this digits.
        public void SumOfArmstrongsNumbers()
        {
            //Max value can`t be more,int our case: 5*9^5
            const int maxValue = 354294;
            int sumOfArmstrongsNumbers = 0;
            int number = 0;

            for (int i = 2; i < maxValue; i++)
            {
                number = SumFifthPower(ArrayOfDigits(Convert.ToString(i)));
                if (i == number)
                {
                    sumOfArmstrongsNumbers += number;
                    Console.WriteLine("Armstrong`s number: " + number);
                }
            }
            Console.WriteLine("The sum of Armstrong`s numbers in fifth power: " + sumOfArmstrongsNumbers);     
        }
    }
}
