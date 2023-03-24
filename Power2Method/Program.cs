using System;

namespace Power2Method
{
    class Program
    {
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
               
        }
        private static void PowersOf2UntilN(int n)
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
            PowersOf2UntilN(12);
            PowersOf2UntilN(15);

        }
   }
}
