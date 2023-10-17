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
            //Caso 0: Creamos un nuevo nodo y le asignamos el dato que ingresamos
            Node NewNode = new Node(data);
            //Caso 1: Insertamso al inicio y comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                Head = NewNode;
                Head.Next = Head;
                LastNode = NewNode;
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
                LastNode = Head;
                Head = NewNode;
                Head.Next.Next = Head;
                return;
            }
            //Caso 4: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 5: El valor a ordenar en la lista no se sabe donde se colocara
            if (NewNode.Data < CurrentNode.Next.Data)
            {
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
                return;
            }
            //Caso 6: El valor a ordenar en la lista es mayor a el ultimo 
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            LastNode = NewNode;
        }

        public void Delete(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: El dato a eliminar esta al inicio de la lista y solo hay 1 elemento
            if (Head.Data == data && LastNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                Clear();
                return;
            }
            //Caso 3: El dato a eliminar esta al inicio de la lista
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                Head = Head.Next;
                return;
            }
            //Caso 3: Preparamos una variable para recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato a eliminar esta en X posicion/Final de la lista
            if (CurrentNode.Next.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                CurrentNode.Next = CurrentNode.Next.Next;
                return;
            }
            //Caso 5: No se encontro el dato a eliminar
            Console.WriteLine($"- Dato[{data}] no existe en la lista");
        }

        public void Search(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Case 2: Comprobamos si el dato esta al inicio de la lista
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 3: Empezamos a recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato ingresado existe X elemento
            if (CurrentNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 5: No existe el dato en la lista
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            //Caso 1: Comprobamos si al lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Preparamos las variables pata empezar a recorrer
            Node CurrentNode = Head;
            int i = 1;
            Console.WriteLine("=== Mi lista Circular ===");
            //Caso 3: Recorremos la lista
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
            //Caso 4: Se han imprimido todos los elementos en pantalla
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
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
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