using System;

namespace All_List.Clases.Listas
{
    public class CircularDoublyLinkedList
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
            }
            else
            {
                LastNode.Next = NewNode;
                NewNode.Next = Head;
                NewNode.Back = LastNode;
                LastNode = NewNode;
                Head.Back = NewNode;
            }
        }

        public void Delete(int data)
        {
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
            DoubleNode CurrentNode = Head;
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