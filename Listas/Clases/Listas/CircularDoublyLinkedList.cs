using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class CircularDoublyLinkedList : ImethodLists
    {
        private DoubleNode Head { get; set; }
        private DoubleNode LastNode { get; set; }

        public CircularDoublyLinkedList()
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
                Head.Next = NewNode;
                Head.Back = NewNode;
                LastNode = Head;
                return;
            }
            if (Exist(NewNode.Data)) //comprobar si ya existe un dato igual al que vamos a ingresar
            {
                return;
            }
            if (NewNode.Data < Head.Data) //ordena el dato si es menor al dato del primer elemento
            {
                Head.Back = NewNode;
                Head.Next = NewNode;
                NewNode.Back = Head;
                NewNode.Next = Head;
                Head = NewNode;
                LastNode = Head;
                return;
            }
            else
            {
                DoubleNode CurrentNode = Head;
                do //recorremos la lista
                {
                    if (NewNode.Data < CurrentNode.Next.Data) //insercion en X posicion
                    {
                        NewNode.Next = CurrentNode.Next;
                        CurrentNode.Next.Back = NewNode;
                        CurrentNode.Next = NewNode;
                        NewNode.Back = CurrentNode;
                        return;
                    }
                    CurrentNode = CurrentNode.Next;
                } while (CurrentNode.Next != Head);
                //insertamos al final
                CurrentNode.Next = NewNode;
                NewNode.Back = CurrentNode;
                Head.Back = NewNode;
                NewNode.Next = Head;
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
            if (Head.Data == data) //Primer elmento
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                Head = Head.Next;
                Head.Back = LastNode;
                LastNode.Next = Head;
                return;
            }
            do
            {
                if (CurrentNode.Next.Data == data)
                {
                    if (CurrentNode.Next == LastNode)//Ultimo elemnto
                    {
                        Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                        LastNode = LastNode.Back;
                        LastNode.Next = Head;
                        return;
                    }
                    //X posicion de la lista
                    Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                    CurrentNode.Next.Back = CurrentNode;
                    CurrentNode.Next = CurrentNode.Next.Next;
                    return;
                }
                CurrentNode = CurrentNode.Next;
            } while (CurrentNode != Head);
            Console.WriteLine($"- Dato[{data}] No existe en la lista");
        }

        public void Search(int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            DoubleNode CopyHead = Head;
            do
            {
                if (CopyHead.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] Existe en la lista ");
                    return;
                }
                CopyHead = CopyHead.Next;
            } while (CopyHead != Head);
            Console.WriteLine($"- Dato[{data}] No existe en la lista ");
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            DoubleNode CopyHead = Head;
            int i = 1;
            Console.WriteLine("=== Mi Lista doblemente enlazada ===");
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CopyHead.Data);
                CopyHead = CopyHead.Next;
                i++;
            } while (CopyHead != Head);
        }

        public bool Exist(int data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (Head != null && Head.Data == data)
            {
                return true;
            }
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head)
            {
                if (CurrentNode.Next.Data >= data)
                {
                    break;
                }
                CurrentNode = CurrentNode.Next;
            }
            if (CurrentNode.Next != null && CurrentNode.Next.Data == data)
            {
                return true;
            }
            return false;
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