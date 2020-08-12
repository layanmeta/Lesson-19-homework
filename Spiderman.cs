using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Spiderman : Human, IClimb
    {


        private int m_Web_Left;

        public int GetWebLeft()
        {
            return m_Web_Left;
        }
       private void SetWebLeft(int webLeft)
        {
            m_Web_Left = webLeft;
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine("Power activating");
        }

        public void Climb()
        {
            Console.WriteLine("climbing");
        }
        public string GetName()
        {
            return "Spiderman";
        }

        private void SetName(String name)
        {
            name = "Spiderman";
        }
        public Spiderman( int m_age, int m_Web_Left) : base( m_age)
        {
            this.m_Web_Left = m_Web_Left;
            GetName();
        }

        protected override string Name { get; set; }

        public override string ToString()
        {
            return $"spiderman's {m_Web_Left}";
        }
    }

}
