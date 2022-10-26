using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Autor:Abdessamad Belmadani
//2022-2023 ESTF GI-GL
namespace Exercice2
{
     class Program
        /*Method push qui fait l'ajout d entier en  basant sur la Position 
         * Adequat retourner par la methode GetPosition qui est défint aprés
         */
    {  public static void Push(int[] Tab,int pos,int n)
        {
            int temp;
            int i;
            for (i=pos;i< Tab.Length-1 ;i++)
            {
                temp = Tab[pos];
                Tab[pos] = n;
                n = temp;

            }
           Tab[Tab.Length-1] = n;
        } 

       //Methode GetPosition return the position in which we will insert the new number
        public static int GetPosition(int[] tab,int n)
        {//si le nombre entrer est grand de tts elements du table pour  retourner sa position a la fin
            int pos =tab.Length+1;
            for (int i = 0; i < tab.Length; i++)
            {
                if (n < tab[i])
                {
                    pos = i;
                    return pos;
                }
            }
            //si l'entier entrer est le plus grand par rapport à tts elements du table
            //Donc on retourne  pos =tab.Length+1
            return pos;
        }
        public static void ShowTable(int[] tab)
        { 
            Console.WriteLine("Affichage du tableau : ");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($" {tab[i]} ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int[] Tab = { 1, 2, 5, 7 };//Tableau initial
            Console.WriteLine("Avant Ajout ");
            ShowTable(Tab);
            int n = 6;
            int Pos = GetPosition(Tab,n);
            // Console.WriteLine(Pos);
            Array.Resize(ref Tab, Tab.Length + 1);//redimensionnement du tableau
            Push(Tab, Pos, n);
            Console.WriteLine($"Résultat Aprés L'ajout d'entier {n} ");
            ShowTable(Tab);

            //  Console.WriteLine($"{ Tab.Length} ");

          // Array.Resize(ref Tab, Tab.Length + 1);
           // ShowTable(Tab);
            // Console.WriteLine($"{Tab.Length}");
           // Tab[4] = 5;
          //  ShowTable(Tab);


        }
    }
}
