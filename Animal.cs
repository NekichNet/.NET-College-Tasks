using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Animal
    {
        protected string name_;
        protected string weight_;
        protected string breed_;
        protected string birthdate_;

        public virtual string Info()
        {
            return $"Name: {name_} Weight: {weight_} Breed: {breed_} Birthdate: {birthdate_}";
        }
    }
}
