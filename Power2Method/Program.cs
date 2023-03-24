using System;

namespace Power2Method
{
    class Program
    {
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= ( 1 << 5 ); i = i << 1 )
            {
                Console.WriteLine(i);
            }   
        }
        private static void PowersOfUntilN(int n)
        {
            for(int i = 1; i <= ( 1 << n ); i = i << 1 )
            {
                Console.WriteLine(i);
            }
        }
        private static void Main()
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOfUntilN(12);
            PowersOfUntilN(15);

        }
   }
}
