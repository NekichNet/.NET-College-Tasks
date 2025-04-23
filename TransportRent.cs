using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class TransportRent<T> where T : ITransport
    {
        private string fullname_;
        private T transport_;
        private float rentTime_;

        public string Info()
        {
            return $"Type: {transport_} Rent: {rentTime_} Cost per min: {transport_.costPerMinute_} Fullname: {fullname_}";
        }
    }
}
