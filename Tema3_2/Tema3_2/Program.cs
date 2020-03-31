using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string copie;
            int LITERE= 26;
            int pozitie, dimensiune;
            string[][] tablou = new string[LITERE][];
            
            for (int i = 0; i < LITERE; i++)
                tablou[i] = new string[0];

            foreach (var arg in args)
            {
                copie = arg.ToUpper();          //TOATE DEVIN UPPER CASE
                pozitie = (int)copie[0] - 65;                     //65=A in tabel ASCII, copie[0]=A convertit in int =65 , scadem 65 si 0 e pozitia initiala    
                Array.Resize(ref tablou[pozitie], tablou[pozitie].Length + 1);                 //crestem dimensiunea in cazul in care avem mai multe cuvinte cu aceeasi litera
                dimensiune = tablou[pozitie].Length;
                tablou[pozitie][dimensiune - 1] = arg;               
                
            }
            for (int i = 0; i < LITERE; i++)
                for (int j = 0; j < tablou[i].Length; j++)
                    Console.WriteLine("Tablou[{0}][{1}] = {2} ", i, j, tablou[i][j]);
            
            Console.ReadKey();
        }
    }
}
