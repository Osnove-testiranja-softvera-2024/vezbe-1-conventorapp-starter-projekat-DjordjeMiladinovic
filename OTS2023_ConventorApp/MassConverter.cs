using OTS2023_ConventorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConvertMass : IConvert
{
    public double Convert(double value)
    {
        return Math.Round(value / 2.205, 3);
    }
    public double ConvertArray(string array)
    {
        string[] values = array.Split(',');

        double number = 0;
        for (int i = 0; i < values.Length; i++)
        {
            number += Double.Parse(values[i]);
        }

        return Convert(number);
    }
}