using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct CarFifth
    {
        private string vin_;
        private string brand_;
        private string model_;
        private int year_;
        private string color_;  

        public string Info()
        {
            return $"VIN: {vin_} Brand: {brand_} Model: {model_} Year: {year_} Color: {color_}";
        }

        public string CheckVin(string actualVin)
        {
            if (actualVin == VinNumber) {
                return "VIN совпадает";
            } else {
                return "VIN не совпадает";
            }
        }
    }
}
