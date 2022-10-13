using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeKiO1
{
    internal class Program
    {
        class Biljka
        {
        }
        class Stablo : Biljka
        {
            bool opadajuListovi;

            public Stablo(bool opadajuListovi)
            {
                this.opadajuListovi = opadajuListovi;
            }

            public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

        }
        class Cvijet : Biljka
        {
        }
        class Bijelogoricno : Stablo
        {
            public Bijelogoricno(bool opadajuListovi) : base(opadajuListovi)
            {
            }
        }
        class Crnogoricno : Stablo
        {
            public Crnogoricno(bool opadajuListovi) : base(opadajuListovi)
            {
            }
        }



        static void Main(string[] args)
        {
         
                Bijelogoricno Hrast = new Bijelogoricno(true);
                Crnogoricno Bor = new Crnogoricno(false);

                Console.WriteLine(Hrast.OpadajuListovi);
                Console.WriteLine(Bor.OpadajuListovi);




                Console.ReadKey();

        }
    }
}

