using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct Car : ITransport
    {
        private string id_;
        private string brand_;
        private string model_;
        private string color_;
        private decimal costPerMinute_;
    }
}