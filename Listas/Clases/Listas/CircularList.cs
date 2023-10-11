using System;

namespace All_List.Clases.Listas
{
    public class CircularList
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
            if (IsEmpty())
            {
                Head = NewNode;
                Head.Next = Head;
                LastNode = Head;
            }
            else
            {
                LastNode.Next = NewNode;
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
            Node CurrentNode = Head;
            while (CurrentNode.Next != null)
            {
                if (CurrentNode.Data == data)
                {
                    return true;
                }
                CurrentNode = CurrentNode.Next;
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