using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class SuperMan : Human, IFly
    {

        private int m_Speed;
        public int GetSpeed()
        {
            return m_Speed;
        }
        private void SetWebLeft(int Speed)
        {
            m_Speed = Speed;
        }

        public string GetName()
        {
            return "Superman";
        }

        private void SetName(String name)
        {
            name = "superman";
        }


        public void ActivateSuperPowers()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public SuperMan( int m_age, int m_Speed) : base( m_age)
        {
            this.m_Speed = m_Speed;
            GetName();
        }

        protected override string Name { get; set; }

        public override string ToString()
        {
            return $"Superman's : {m_Speed}";
        }
    }
}
