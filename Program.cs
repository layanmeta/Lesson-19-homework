using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class Program
    {
        static void ActivateHero(IsuperHero Hero)
        {
            Hero.ActivateSuperPowers();

        }
        static void IdentifyHero(IsuperHero Hero)
        {
            if (Hero is Flash)
            {
                Console.WriteLine("Flash detected");
            }
            else if (Hero is Spiderman)
            {

                Console.WriteLine("Spiderman detected");
            }
            else
            {

                Console.WriteLine("Superman detected");
            }
        }
        static void GetMoreHeroData(IsuperHero Hero)
        {
            if (Hero is Flash)
            {
                Flash flash = Hero as Flash;
                Console.WriteLine(flash.GetVoltage());

            }
            else if (Hero is Spiderman)
            {

                Spiderman spiderman = Hero as Spiderman;
                Console.WriteLine(spiderman.GetWebLeft());
            }
            else
            {
                SuperMan superman = Hero as SuperMan;

                Console.WriteLine(superman.GetSpeed());
            }
        }

        static IsuperHero CreateHero(string superhero)
        {
            if (superhero == "superman")
            {
                SuperMan super = new SuperMan(30, 50000);
                return super;
            }
            else if (superhero == "spiderman")
            {
                Spiderman spider = new Spiderman(20, 3000);
                return spider;
            }
            else if (superhero == "flash")
            {
                Flash flash = new Flash(18, 2000);
                return flash;
            }
            else
            {
                return null;
            }
        }



        static void Main(string[] args)
        {
            Flash Barry_Allen = new Flash(24, 2000);
            SuperMan Clark_Kent = new SuperMan(34, 10000);
            Spiderman Peter_Parker = new Spiderman(28, 2);

            IsuperHero[] heroes = { Barry_Allen, Clark_Kent, Peter_Parker };
            {
                foreach (IsuperHero hero in heroes)
                {
                    ActivateHero(hero);
                }

            }



        }
    }
}
