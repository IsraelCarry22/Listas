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
            //Caso 1: Insertamso al inicio y comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                NewNode.Next = null;
                NewNode.Back = null;
                Head = NewNode;
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
                Head.Back = NewNode;
                NewNode.Next = Head;
                Head = LastNode;
                Head = NewNode;
                return;
            }
            //Caso 4: El valor a ordenar en la lista es mayor a el ultimo 
            if (NewNode.Data > LastNode.Data)
            {
                LastNode.Next = NewNode;
                NewNode.Back = LastNode;
                LastNode = NewNode;
                return;
            }
            //Caso 5: El valor a ordenar en la lista no se sabe donde se colocara
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data < NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            NewNode.Back = CurrentNode;
            CurrentNode.Next.Back = NewNode;
            CurrentNode.Next = NewNode;
        }

        public void Delete(int data)
        {
            //Caso 1: Comprobamos si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: El dato a eliminar esta al inicio de la lista
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                Head.Next.Back = null;
                Head = Head.Next;
                return;
            }
            //Caso 3: Empezamos a recorrer la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data <= data)
            {
                //Caso 3: El dato a eliminar esta en X posicion de la lista
                if (CurrentNode.Next.Data == data)
                {
                    Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                    CurrentNode.Next.Next.Back = CurrentNode;
                    CurrentNode.Next = CurrentNode.Next.Next;
                    return;
                }
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato a eliminar esta al ultimo de la lista
            if (CurrentNode.Next == LastNode)
            {
                Console.WriteLine($"- Dato[{data}] se elimino de la lista");
                LastNode = CurrentNode;
                LastNode.Next = null;
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
            //Caso 2: Recorremos la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 3: Si existe el dato en la lista
            if (CurrentNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 4: No existe el dato en la lista
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
            DoubleNode CurrentNode = Head;
            int i = 1;
            Console.WriteLine("=== Mi Lista doblemente enlazada ===");
            //Caso 3: Recorremos la lista
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
            //Caso 4: Se han imprimido todos los elementos en pantalla
        }

        public void ShowRevers()
        {
            //Caso 1: Comprobamos si la lsita esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: preparamos las variables para empezar a recorrer la lista
            DoubleNode CurrentNode = LastNode;
            int i = 1;
            Console.WriteLine("=== Mi Lista doblemente enlazada Reversa===");
            //Caso 3: recorremos la lista al revez
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != null);
            //Caso 4: Los datos de la lista se a imprimido al revez y se muestran en pantalla
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
            DoubleNode CurrentNode = Head;
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