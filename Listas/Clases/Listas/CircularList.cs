using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class CircularList : ImethodLists
    {
        private Node Head { get; set; }
        private Node LastNode { get; set; }

        public CircularList()
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
                Head.Next = Head;
                LastNode = NewNode;
                return;
            }
            if (Exist(NewNode.Data)) //comprobar si ya existe un dato igual al que vamos a ingresar
            {
                return;
            }
            if (NewNode.Data < Head.Data) //ordena el dato si es menor al dato del primer elemento
            {
                NewNode.Next = Head;
                LastNode = Head;
                Head = NewNode;
                Head.Next.Next = Head;
                return;
            }
            else
            {
                Node CurrentNode = Head;
                do //recorremos la lista
                {
                    if (NewNode.Data < CurrentNode.Next.Data) //Insertamos en X posicion
                    {
                        NewNode.Next = CurrentNode.Next;
                        CurrentNode.Next = NewNode;
                        return;
                    }
                    CurrentNode = CurrentNode.Next;
                } while (CurrentNode.Next != Head);
                //insertamos al final de la lista
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
                LastNode = NewNode;
            }
        }

        public void Delete(int data)
        {
            if (IsEmpty())
            {
                return;
            }
            Node CurrentNode = Head;
            do
            {
                if (CurrentNode.Next.Data == data)
                {
                    if (CurrentNode.Next == Head) //Primer elemento
                    {
                        Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                        Head = Head.Next;
                        LastNode.Next = Head;
                        return;
                    }
                    if (CurrentNode.Next == LastNode) //Ultimo elemento
                    {
                        Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                        CurrentNode.Next = Head;
                        LastNode = CurrentNode;
                        return;
                    }
                    //X posicion de la lista
                    Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                    CurrentNode.Next = CurrentNode.Next.Next;
                    return;
                }
                CurrentNode = CurrentNode.Next;
            } while (CurrentNode != Head);
            Console.WriteLine($"- Dato[{data}] no existe en la lista");
        }

        public void Search(int data)
        {
            if (IsEmpty())
            {
                return;
            }
            Node CurrentNode = Head;
            do
            {
                if (CurrentNode.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] Existe en la lista");
                    return;
                }
                CurrentNode = CurrentNode.Next;
            } while (CurrentNode != Head);
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            Node CurrentNode = Head;
            int i = 1;
            Console.WriteLine("=== Mi lista Circular ===");
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
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