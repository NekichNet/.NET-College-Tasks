using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct Scooter : ITransport
    {
        private string model_;
        private int yearOfRelease_;
        private decimal costPerMinute_;
    }
}
