using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Flash : Human, IFlash
    {

        private int m_Voltage;
        public int GetVoltage()
        {
            return m_Voltage;
        }
        private void SetWebLeft(int Voltage)
        {
            m_Voltage = Voltage;
        }

        public string GetName()
        {
            return "Flash";
        }

        private void SetName(String name)
        {
            name = "flsah";
        }

        public Flash( int m_age, int m_Voltage) : base( m_age)
        {
            this.m_Voltage = m_Voltage;
            GetName();
        }

        protected override string Name { get; set; }

        public void ActivateSuperPowers()
        {
            Console.WriteLine("power is activating");
        }

        public void FireLightning()
        {
            Console.WriteLine("using FireLightning ");
        }

        public override string ToString()
        {
            return $"flash's super power : {m_Voltage}";
        }
    }
}
