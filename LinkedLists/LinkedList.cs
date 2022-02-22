using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            Count++;
        }

        public int IndexOf(int value)
        {
            int position = 0;
            Node nodeToFind = Head;
            while (nodeToFind != null)
            {
                if (nodeToFind.Value == value)
                {
                    return position;
                }
                else
                {
                    nodeToFind = nodeToFind.Next;
                }

                position++;
            }

            return -1;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                throw new Exception("La lista è vuota!");
            }

            if (Head == Tail) //La lista ha un solo elemento.
            {
                Head = null;
                Tail = null;
                return;
            }

            Node second = Head.Next;
            Head.Next = null; //Per permmettere al garbage collector di rimuovere l'elemento.
            Head = second;

            Count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                throw new Exception("La lista è vuota!");
            }

            if (Head == Tail) //La lista ha un solo elemento.
            {
                Head = null;
                Tail = null;
                return;
            }

            Node currentNode = Head;
            while(currentNode.Next != Tail)
            {
                currentNode = currentNode.Next;
            }

            Tail = currentNode; // La coda è ora il penultimo elemento.
            Tail.Next = null;

            Count--;
        }

        public void Reverse()
        {
            Node tmp = Head;
            Node revHead = null;
            Node prev = null;

            while (tmp != null)
            {
                revHead = new Node(0);
                revHead.Value = tmp.Value;
                revHead.Next = prev;
                prev = revHead;

                tmp = tmp.Next;
            }

            Head = revHead;
        }
    }
}
