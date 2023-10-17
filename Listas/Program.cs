using All_List.Clases.Listas;
using System;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RL = new Random();
            bool Exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("#Ver todas las Listas#\n[1]Lista simple.\n[2]Lista circular.\n[3]Lista doble enlazada.\n[4]Lista circular doble enlazada.\n[5]Salir.");
                Console.Write("Ingresa una opcion (1 - 5):");
                int Op = int.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("== Random list ==");
                        SimpleList RSList = new SimpleList();
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Add(RL.Next(1, 10));
                        RSList.Show();
                        Console.WriteLine();
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RSList.Show();
                        RSList.Search(RL.Next(1, 10));
                        RSList.Search(RL.Next(1, 10));
                        RSList.Search(RL.Next(1, 10));
                        RSList.Search(RL.Next(1, 10));
                        RSList.Search(RL.Next(1, 10));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        CircularDoublyLinkedList cr = new CircularDoublyLinkedList();
                        cr.Add(1);
                        cr.Add(5);
                        cr.Add(7);
                        cr.Add(9);
                        cr.Add(2);
                        cr.Add(8);
                        cr.Add(3);
                        cr.Add(6);
                        cr.Show();
                        Console.WriteLine();
                        cr.Delete(1);
                        cr.Delete(5);
                        cr.Delete(7);
                        cr.Delete(9);
                        cr.Delete(2);
                        cr.Delete(8);
                        cr.Delete(3);
                        cr.Delete(6);
                        cr.Delete(9);
                        Console.WriteLine();
                        cr.Show();
                        //Console.WriteLine("== Random list ==");
                        //CircularList RCList = new CircularList();
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Add(RL.Next(1, 10));
                        //RCList.Show();
                        //Console.WriteLine();
                        //RCList.Delete(RL.Next(1, 10));
                        //RCList.Delete(RL.Next(1, 10));
                        //RCList.Delete(RL.Next(1, 10));
                        //RCList.Delete(RL.Next(1, 10));
                        //RCList.Delete(RL.Next(1, 10));
                        //Console.WriteLine();
                        //RCList.Search(RL.Next(1, 10));
                        //RCList.Search(RL.Next(1, 10));
                        //RCList.Search(RL.Next(1, 10));
                        //RCList.Search(RL.Next(1, 10));
                        //RCList.Search(RL.Next(1, 10));
                        //Console.WriteLine();
                        //RCList.Show();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("== Random list ==");
                        DoublyListLinked RDLList = new DoublyListLinked();
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Add(RL.Next(1, 10));
                        RDLList.Show();
                        Console.WriteLine();
                        RDLList.Delete(RL.Next(1, 10));
                        RDLList.Delete(RL.Next(1, 10));
                        RDLList.Delete(RL.Next(1, 10));
                        RDLList.Delete(RL.Next(1, 10));
                        RDLList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RDLList.Show();
                        Console.WriteLine();
                        RDLList.Search(RL.Next(1, 10));
                        RDLList.Search(RL.Next(1, 10));
                        RDLList.Search(RL.Next(1, 10));
                        RDLList.Search(RL.Next(1, 10));
                        RDLList.Search(RL.Next(1, 10));
                        Console.WriteLine();
                        RDLList.ShowRevers();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("== Random list ==");
                        CircularDoublyLinkedList RCDLList = new CircularDoublyLinkedList();
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Add(RL.Next(1, 10));
                        RCDLList.Show();
                        Console.WriteLine();
                        RCDLList.Delete(RL.Next(1, 10));
                        RCDLList.Delete(RL.Next(1, 10));
                        RCDLList.Delete(RL.Next(1, 10));
                        RCDLList.Delete(RL.Next(1, 10));
                        RCDLList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RCDLList.Show();
                        RCDLList.Search(RL.Next(1, 10));
                        RCDLList.Search(RL.Next(1, 10));
                        RCDLList.Search(RL.Next(1, 10));
                        RCDLList.Search(RL.Next(1, 10));
                        RCDLList.Search(RL.Next(1, 10));
                        Console.WriteLine();
                        RCDLList.ShowRevers();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Fin del programa...");
                        Console.ReadKey();
                        Exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingresa un valor de (1 a 5)...");
                        Console.ReadKey();
                        break;
                }
            } while (!Exit);
        }
    }
}