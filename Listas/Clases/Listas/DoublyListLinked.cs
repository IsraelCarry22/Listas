using Listas.Interfaces;
using System;
using System.ComponentModel.Design;
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
            if (IsEmpty()) //insertar al inicio/comprobar si al lista esta vacia
            {
                NewNode.Next = null;
                NewNode.Back = null;
                Head = NewNode;
                LastNode = NewNode;
                return;
            }
            if (Exist(NewNode.Data)) //comprobar si ya existe un dato igual al que vamos a ingresar
            {
                return;
            }
            if (NewNode.Data < Head.Data) //ordena el dato si es menor al dato del primer elemento
            {
                Head.Back = NewNode;
                NewNode.Next = Head;
                Head = LastNode;
                Head = NewNode;
                return;
            }
            else
            {
                DoubleNode CurrentNode = Head;
                while (CurrentNode.Next != null) //recorremos la lista
                {
                    if (NewNode.Data < CurrentNode.Next.Data) //insertamos en X posicion
                    {
                        NewNode.Next = CurrentNode.Next;
                        NewNode.Back = CurrentNode;
                        CurrentNode.Next = NewNode;
                        NewNode.Next.Back = NewNode;
                        return;
                    }
                    CurrentNode = CurrentNode.Next;
                }
                //insertamos al final
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
                NewNode.Back = CurrentNode;
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
            while (CurrentNode.Next != null)
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