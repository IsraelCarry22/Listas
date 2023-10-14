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
                        SimpleList SList = new SimpleList();
                        SList.Add(23);
                        SList.Add(1);
                        SList.Add(789);
                        SList.Add(456);
                        SList.Add(3);
                        SList.Show();
                        SList.Search(1);
                        SList.Search(456);
                        SList.Search(23);
                        SList.Delete(1);
                        SList.Delete(456);
                        SList.Delete(23);
                        SList.Show();
                        Console.WriteLine("== Random list ==");
                        SimpleList RList = new SimpleList();
                        RList.Add(RL.Next(1, 5));
                        RList.Add(RL.Next(1, 5));
                        RList.Add(RL.Next(1, 5));
                        RList.Add(RL.Next(1, 5));
                        RList.Add(RL.Next(1, 5));
                        RList.Show();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        CircularList CList = new CircularList();
                        CList.Add(23);
                        CList.Add(1);
                        CList.Add(789);
                        CList.Add(456);
                        CList.Add(3);
                        CList.Show();
                        CList.Search(1);
                        CList.Search(456);
                        CList.Search(23);
                        CList.Delete(1);
                        CList.Delete(456);
                        CList.Delete(23);
                        CList.Show();
                        Console.WriteLine("== Random list ==");
                        CircularList RCList = new CircularList();
                        RCList.Add(RL.Next(1, 5));
                        RCList.Add(RL.Next(1, 5));
                        RCList.Add(RL.Next(1, 5));
                        RCList.Add(RL.Next(1, 5));
                        RCList.Add(RL.Next(1, 5));
                        RCList.Show();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        DoublyListLinked LList = new DoublyListLinked();
                        LList.Add(23);
                        LList.Add(1);
                        LList.Add(789);
                        LList.Add(456);
                        LList.Add(3);
                        LList.Show();
                        LList.ShowRevers();
                        LList.Search(1);
                        LList.Search(456);
                        LList.Search(23);
                        LList.Delete(1);
                        LList.Delete(456);
                        LList.Delete(23);
                        LList.Show();
                        Console.WriteLine("== Random list ==");
                        DoublyListLinked RLList = new DoublyListLinked();
                        RLList.Add(RL.Next(1, 5));
                        RLList.Add(RL.Next(1, 5));
                        RLList.Add(RL.Next(1, 5));
                        RLList.Add(RL.Next(1, 5));
                        RLList.Add(RL.Next(1, 5));
                        RLList.Show();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        CircularDoublyLinkedList CDList = new CircularDoublyLinkedList();
                        CDList.Add(23);
                        CDList.Add(1);
                        CDList.Add(789);
                        CDList.Add(456);
                        CDList.Add(3);
                        CDList.Show();
                        CDList.ShowRevers();
                        CDList.Search(1);
                        CDList.Search(456);
                        CDList.Search(23);
                        CDList.Delete(1);
                        CDList.Delete(456);
                        CDList.Delete(23);
                        CDList.Show();
                        Console.WriteLine("== Random list ==");
                        CircularDoublyLinkedList RCDList = new CircularDoublyLinkedList();
                        RCDList.Add(RL.Next(1, 5));
                        RCDList.Add(RL.Next(1, 5));
                        RCDList.Add(RL.Next(1, 5));
                        RCDList.Add(RL.Next(1, 5));
                        RCDList.Add(RL.Next(1, 5));
                        RCDList.Show();
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

        private static int IngresaValor()
        {
            Console.Write("Ingreas un numero: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
