using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    public class FeaturesCinema
    {
        private string title_;
        private decimal cost_;
        private int amountOfViewers_;
        private string room_;

        public string Info
        {
            get
            {
                return $"Title: {title_} Cost: {cost_} Viewers: {amountOfViewers_} Room: {room_}";
            }
        }

        public FeaturesCinema(string title, decimal cost, int amountOfViewers, string showroom) {
            title_ = title;
            cost_ = cost;
            amountOfViewers_ = amountOfViewers;
            showroom_ = showroom;
        }
    }
}
