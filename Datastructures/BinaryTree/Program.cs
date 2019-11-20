using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BinaryTreeApp.models;

namespace BinaryTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            int? bti1 = 20, bti2 = 5, bti3 = 30, bti4 = 2, bti5 = 5, bti6 = 6, bti7 = 7, bti8 = 8, bti9 = 9, bti10 = 10;

            bt.Add(bti1);
            bt.Add(bti2);
            bt.Add(bti3);
            bt.Add(bti4);
            bt.Add(bti5);
            bt.Add(bti6);
            bt.Add(bti7);
            bt.Add(bti8);
            bt.Add(bti9);
            bt.Add(bti10);



            Console.WriteLine(bt.Maximum(bti2));
            Console.WriteLine(bt.Minimum());
            Console.WriteLine(bt.Find(bti4));
            Console.WriteLine(bt.FindItemBefore(bti2));
            Console.WriteLine(bt.MinimumBefore(bti2));
            Console.WriteLine(bt.Remove(bti4));
            Console.WriteLine(bt.Find(bti4));
            



            //Add() Test
            /*
            Console.WriteLine("Bitte Zahl eingeben:");
            int inputZahl = Convert.ToInt32(Console.ReadLine());

            bt.Add(inputZahl);
            */

            //Count() Test
            /*
            Console.WriteLine("Anzahl der Elemente: {0}", bt.Count);
            */

            //Find() Test
            /*
            Console.WriteLine("Zahl suchen:");
            int zahlZumSuchen = Convert.ToInt32(Console.ReadLine());

            BinaryTreeItem gefundeneZahl = bt.Find(zahlZumSuchen);
            Console.WriteLine("Gefundene Zahl:");
            Console.WriteLine(gefundeneZahl);
            */



            Console.ReadKey();
        }
    }
}
