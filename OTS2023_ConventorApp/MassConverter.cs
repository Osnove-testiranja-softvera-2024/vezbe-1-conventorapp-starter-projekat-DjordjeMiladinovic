using OTS2023_ConventorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MassConverter : IConvert
{
    public double Convert(double value)
    {
        return Math.Round(value / 2.205, 3);
    }


}