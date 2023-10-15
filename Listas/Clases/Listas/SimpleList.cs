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
            //Caso 0: Creamos un nuevo nodo y le asignamos el dato que ingresamos
            Node NewNode = new Node
            {
                Data = data
            };
            //Caso 1: Insertamso al inicio y comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                Head = NewNode;
                return;
            }
            //Caso 2: impedimos si al dato del nuevo nodo ya existe en la lista
            if (Exist(NewNode.Data))
            {
                return;
            }
            //Caso 3: el dato del nuevo nodo es menor al dato de Head
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            else
            {
                Node CurrentNode = Head;
                while (CurrentNode.Next != null)
                {
                    if (NewNode.Data < CurrentNode.Next.Data)
                    {
                        break;
                    }
                    CurrentNode = CurrentNode.Next;
                }
                //Caso 4: El valor ordeno se inserta en X posicion o al final de la lista
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
            }
        }

        public void Delete(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: el primer elemento tiene el dato a eliminar
            if (Head.Data == data)
            {
                Head = Head.Next;
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                return;
            }
            //Caso 3: empezamos a recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: se encontro el dato a eliminar
            if (CurrentNode.Next.Data == data)
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                return;
            }
            //Caso 5: no se encontro el dato a eliminar
            Console.WriteLine($"- Dato[{data}] no existe en la lista");
        }

        public void Search(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia...");
                return;
            }
            //Caso 2: Comprobamos si es dato esta al inicio
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 3: Empezamos a recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode != null)
            {
                if (CurrentNode.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] Existe en la lista");
                    return;
                }
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato que queremos busacar no existe
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            int i = 1;
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Recorremos la lista y la imprimimos en pantalla
            Node CurrentNode = Head;
            Console.WriteLine("=== Mi lista simple ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
            //Caso 3: Se han imprimido todos los elemetos en pantalla
        }

        public bool Exist(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                return false;
            }
            //Caso 2: Comprobamos si el primer elemento ya tiene le mismo dato ingresado
            if (Head.Data == data)
            {
                return true;
            }
            //Caso 3: Empezamos a recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato ingresado existe en el ultimo elemento
            if (CurrentNode.Data == data)
            {
                return true;
            }
            //Caso 5: El dato no existe en la lista
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