using System;

namespace DeclaringRealTypes
{
    class DeclaringRealTypes
    {
        protected DeclaringRealTypes()
        {

        }

        static void Main()
        {
            // float guarda a precisão de 7 dígitos, somando os antes e depois da vírgula
            
            // double guarda a precisão de 15 dígitos, somando os antes e depois da vírgula
            
            // decimal guarda a precisão de 29 dígitos, somando os antes e depois da vírgula

            /* 
               decimal é ideal para cálculos financeiros pela precisão, porém 
               ele trabalha com base 10, então todo cálculo é feito via 
               software e não no microprocessador, o que deixa ele dezenas de 
               milhares de vezes mais lento que float e double. Usar apenas 
               quando necessário
            */

            float r1 = 5F;
            float r2 = -5.01F;
            double r3 = 34.567839023D; // double não precisa ter o D indicando
            float r4 = 12.345F;
            double r5 = 8923.1234857D;
            decimal r6 = 3456.091124875956542151256683467M; //31 dígitos, mesmo sendo decimal vai perder 2 casas
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);
            Console.WriteLine("r3 = " + r3);
            Console.WriteLine("r4 = " + r4);
            Console.WriteLine("r5 = " + r5);
            Console.WriteLine("r6 = " + r6);
        }
    }
}
