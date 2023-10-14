using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class SimpleList : ImethodLists
    {
        private Node Head { get; set; }

        public SimpleList()
        {
            Clear();
        }

        public void Add(int data)
        {
            Node NewNode = new Node
            {
                Data = data
            };
            if (IsEmpty()) //insertar al inicio/comprobar si al lista esta vacia
            {
                Head = NewNode;
                return;
            }
            if (Exist(NewNode.Data)) //comprobar si ya existe un dato igual al que vamos a ingresar
            {
                return;
            }
            if (NewNode.Data < Head.Data) //ordena el dato si es menor al dato del primer elemento
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            else
            {
                Node CurrentNode = Head;
                while (CurrentNode.Next != null) //se recorre la lista asta llegar al final
                {
                    if (NewNode.Data < CurrentNode.Next.Data)
                    {
                        break;
                    }
                    CurrentNode = CurrentNode.Next;
                }
                //llegado a este punto se inserta en X posicion/final de la lista
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
            }
        }

        public void Delete(int data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (Head.Data == data)
            {
                Head = Head.Next;
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                return;
            }
            Node CurrentNode = Head;
            while (CurrentNode.Next != null)
            {
                if (CurrentNode.Next.Data == data)
                {
                    CurrentNode.Next = CurrentNode.Next.Next;
                    Console.WriteLine($"- Dato[{data}] se elimino de la lista");
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
                Console.WriteLine("Lista vacia...");
                return;
            }
            Node CurrentNode = Head;
            while (CurrentNode.Next != null)
            {
                if (CurrentNode.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] Existe en la lista");
                    return;
                }
                CurrentNode = CurrentNode.Next;
            }
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            int i = 1;
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            Node CurrentNode = Head;
            Console.WriteLine("=== Mi lista simple ===");
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
            Node CurrentNode = Head;
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