using System;

namespace Program
{

    class Bisextile
    {

        static public void Main()
        {

            static void IfYearIsLeap(int year)
            {

                if ((year % 4 == 0) && (year % 100 != 0))
                {
                    Console.WriteLine(year + " est une année bisextile");
                }
                else
                {
                    Console.WriteLine(year + " n'est PAS une année bisextile");
                }

            }


            IfYearIsLeap(2016);
            IfYearIsLeap(2018);
            IfYearIsLeap(2012);


        }
    }
}