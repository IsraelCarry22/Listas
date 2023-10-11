using All_List.Clases.Listas;
using System;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        SList.Add(1);
                        SList.Add(10);
                        SList.Add(100);
                        SList.Add(1000);
                        SList.Add(10000);
                        SList.Show();
                        SList.Delete(1);
                        SList.Delete(100);
                        SList.Delete(10000);
                        SList.Show();
                        SList.Search(1);
                        SList.Search(100);
                        SList.Search(10000);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        CircularList CList = new CircularList();
                        CList.Add(1);
                        CList.Add(10);
                        CList.Add(100);
                        CList.Add(1000);
                        CList.Add(10000);
                        CList.Show();
                        CList.Delete(1);
                        CList.Delete(100);
                        CList.Delete(10000);
                        CList.Show();
                        CList.Search(1);
                        CList.Search(100);
                        CList.Search(10000);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        DoublyListLinked LList = new DoublyListLinked();
                        LList.Add(1);
                        LList.Add(10);
                        LList.Add(100);
                        LList.Add(1000);
                        LList.Add(10000);
                        LList.Show();
                        LList.Delete(1);
                        LList.Delete(100);
                        LList.Delete(10000);
                        LList.Show();
                        LList.Search(1);
                        LList.Search(100);
                        LList.Search(10000);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        CircularDoublyLinkedList CDList = new CircularDoublyLinkedList();
                        CDList.Add(1);
                        CDList.Add(10);
                        CDList.Add(100);
                        CDList.Add(1000);
                        CDList.Add(10000);
                        CDList.Show();
                        CDList.Delete(1);
                        CDList.Delete(100);
                        CDList.Delete(10000);
                        CDList.Show();
                        CDList.Search(1);
                        CDList.Search(100);
                        CDList.Search(10000);
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
            Console.ReadKey();
        }

        private static int IngresaValor()
        {
            Console.Write("Ingreas un numero: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
