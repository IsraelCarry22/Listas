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
                        Console.WriteLine("== Random list ==");
                        CircularList RCSList = new CircularList();
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Add(RL.Next(1, 10));
                        RCSList.Show();
                        Console.WriteLine();
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RCSList.Show();
                        Console.WriteLine();
                        RCSList.Search(RL.Next(1, 10));
                        RCSList.Search(RL.Next(1, 10));
                        RCSList.Search(RL.Next(1, 10));
                        RCSList.Search(RL.Next(1, 10));
                        RCSList.Search(RL.Next(1, 10));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("== Random list ==");
                        DoublyListLinked dl = new DoublyListLinked();
                        dl.Add(7);
                        dl.Add(2);
                        dl.Add(5);
                        dl.Add(1);
                        dl.Add(3);
                        dl.Add(8);
                        dl.Add(4);
                        dl.Add(9);
                        dl.Add(6);
                        dl.Show();
                        Console.WriteLine();
                        dl.Delete(9);
                        dl.Delete(1);
                        dl.Delete(5);
                        dl.Delete(6);
                        dl.Delete(3);
                        dl.Delete(2);
                        dl.Delete(4);
                        dl.Delete(7);
                        dl.Delete(8);
                        Console.WriteLine();
                        dl.Show();
                        Console.WriteLine();
                        dl.ShowRevers();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        CircularDoublyLinkedList cdl = new CircularDoublyLinkedList();
                        cdl.Add(7);
                        cdl.Add(2);
                        cdl.Add(5);
                        cdl.Add(1);
                        cdl.Add(3);
                        cdl.Add(8);
                        cdl.Add(4);
                        cdl.Add(9);
                        cdl.Add(6);
                        cdl.Show();
                        Console.WriteLine();
                        cdl.Delete(9);
                        cdl.Delete(1);
                        cdl.Delete(5);
                        cdl.Delete(6);
                        cdl.Delete(3);
                        cdl.Delete(2);
                        cdl.Delete(4);
                        cdl.Delete(7);
                        cdl.Delete(8);
                        Console.WriteLine();
                        cdl.Show();
                        Console.WriteLine();
                        cdl.ShowRevers();
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