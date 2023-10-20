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
                        RSList.Add(9);
                        RSList.Show();
                        Console.WriteLine();
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(RL.Next(1, 10));
                        RSList.Delete(9);
                        Console.WriteLine();
                        RSList.Show();
                        Console.WriteLine();
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
                        RCSList.Add(9);
                        RCSList.Show();
                        Console.WriteLine();
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(RL.Next(1, 10));
                        RCSList.Delete(9);
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
                        DoublyListLinked RDList = new DoublyListLinked();
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Add(RL.Next(1, 10));
                        RDList.Show();
                        Console.WriteLine();
                        RDList.Delete(RL.Next(1, 10));
                        RDList.Delete(RL.Next(1, 10));
                        RDList.Delete(RL.Next(1, 10));
                        RDList.Delete(RL.Next(1, 10));
                        RDList.Delete(RL.Next(1, 10));
                        RDList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RDList.Show();
                        Console.WriteLine();
                        RDList.ShowRevers();
                        Console.WriteLine();
                        RDList.Search(RL.Next(1, 10));
                        RDList.Search(RL.Next(1, 10));
                        RDList.Search(RL.Next(1, 10));
                        RDList.Search(RL.Next(1, 10));
                        RDList.Search(RL.Next(1, 10));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("== Random list ==");
                        CircularDoublyLinkedList RCDList = new CircularDoublyLinkedList();
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Add(RL.Next(1, 10));
                        RCDList.Show();
                        RCDList.IsEmpty();
                        RCDList.IsEmpty();
                        Console.WriteLine();
                        RCDList.Delete(RL.Next(1, 10));
                        RCDList.Delete(RL.Next(1, 10));
                        RCDList.Delete(RL.Next(1, 10));
                        RCDList.Delete(RL.Next(1, 10));
                        RCDList.Delete(RL.Next(1, 10));
                        Console.WriteLine();
                        RCDList.Show();
                        Console.WriteLine();
                        RCDList.ShowRevers();
                        Console.WriteLine();
                        RCDList.Search(RL.Next(1, 10));
                        RCDList.Search(RL.Next(1, 10));
                        RCDList.Search(RL.Next(1, 10));
                        RCDList.Search(RL.Next(1, 10));
                        RCDList.Search(RL.Next(1, 10));
                        RCDList.IsEmpty();
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