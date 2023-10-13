using Listas.Interfaces;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace All_List.Clases.Listas
{
    public class DoublyListLinked : ImethodLists
    {
        private DoubleNode Head { get; set; }
        private DoubleNode LastNode { get; set; }

        public DoublyListLinked()
        {
            Clear();
        }

        public void Add(int data)
        {
            DoubleNode NewNode = new DoubleNode
            {
                Data = data
            };
            if (IsEmpty())
            {
                Head = NewNode;
                Head.Next = null;
                Head.Back = null;
                LastNode = Head;
            }
            else
            {
                LastNode.Next = NewNode;
                NewNode.Next = null;
                NewNode.Back = LastNode;
                LastNode = NewNode;
            }
        }

        public void Delete(int data)
        {
            if (IsEmpty())
            {
                return;
            }
            DoubleNode CurrentNode = Head;
            if (Head.Data == data) //Primer elemento
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                Head.Next.Back = null;
                Head = Head.Next;
                return;
            }
            while (CurrentNode.Next != null)
            {
                if (CurrentNode.Next.Data == data)
                {
                    if (CurrentNode.Next == LastNode) //Ultimo elemento
                    {
                        Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                        LastNode = CurrentNode;
                        LastNode.Next = null;
                        return;
                    }
                    //X posicion de la lista
                    Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                    CurrentNode.Next.Next.Back = CurrentNode;
                    CurrentNode.Next = CurrentNode.Next.Next;
                    return;
                }
                CurrentNode = CurrentNode.Next;
            }
            Console.WriteLine($"- Dato[{data}] no existe en la lista");
        }

        public void Search(int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            if (IsEmpty())
            {
                return;
            }
            DoubleNode CurrentNode = Head;
            while (CurrentNode != null)
            {
                if (CurrentNode.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] Existe en la lista ");
                    return;
                }
                CurrentNode = CurrentNode.Next;
            }
            Console.WriteLine($"- Dato[{data}] No existe en la lista ");
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            DoubleNode CurrentNode = Head;
            int i = 1;
            Console.WriteLine("=== Mi Lista doblemente enlazada ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}