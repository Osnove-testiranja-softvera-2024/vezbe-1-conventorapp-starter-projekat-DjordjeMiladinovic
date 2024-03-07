using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class LenghtConverter
    {
        public class LengthConverter : IConvert
        {
            public double Convert(double value)
            {
                return Math.Round(value / 3.281, 3);
            }

            public double ConvertArray(string array)
            {
                List<String> values = array.Split(',').ToList();
                double[] numbers = Class.Utilities.ConvertArray(values);

                double number = 0;
                for (int i = 0; i < values.Count; i++)
                {
                    number += numbers[i];
                }
                return number;
            }

        }
    }
