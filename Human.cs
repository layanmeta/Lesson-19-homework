using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
  abstract class Human
    {
        private int m_age;

        protected abstract string Name { get; set; }
        
        public int Age { get; }

        public Human(int m_age)
        {
            this.m_age = m_age;
           
        }

        public override string ToString()
        {
            return $"the age is {m_age}";
        }

    }
}
