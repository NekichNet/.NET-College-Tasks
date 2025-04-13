using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class State
    {
        private string name_;
        private int population_;
        private double area_;

        public State(string name, int population, double area)
        {
            name_ = name;
            population_ = population;
            area_ = area;
        }

        public static State operator +(State a, State b)
        {
            if (a != null || b != null)
            {

                string newName = a.name_ + " & " + b.name_;
                int newPopulation = a.population_ + b.population_;
                double newArea = a.area_ + b.area_;

                return new State(newName, newPopulation, newArea);
            }
            else { return null; }
        }

        public static bool operator <(State a, State b)
        {
            if (a != null || b != null)
            {
                if (a.population_ != b.population_)
                {
                    return a.population_ < b.population_;
                }
                else
                {
                    return a.area_ < b.area_;
                }
            }
            else { return false; }
        }

        public static bool operator >(State a, State b)
        {
            if (a != null || b != null)
            {
                if (a.population_ != b.population_)
                {
                    return a.population_ > b.population_;
                }
                else
                {
                    return a.area_ > b.area_;
                }
            }
            else { return false; }
        }

        public override string ToString()
        {
            return $"Name: {name_}, Population: {population_}, Area: {area_}";
        }

        public double getPopulation() { return population_; }
        public double getArea() { return area_; }
    }
}
