using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty
            Node temp = new Node(val);
            if (First==null)
            {
                First = temp; return;
            }
            Node move = First;
            while (move.Next!=null)
            {
                move = move.Next;
            }
            move.Next = temp;
            // create a new node with the given data
        }
        public void RemoveKey(int key)
        {
            if (First==null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            if (First.Data==key)
            {
                Node t = First;
                First = First.Next;
                t.Next = null;
                return;
            }
            Node move = First;
            while (move.Next!=null && move.Next.Data!=key)
            {
                move=move.Next;
            }
            Node temp = move.Next;
            if (move.Next!=null)
            {
                move.Next = move.Next.Next;
                temp.Next = null;
                return;
            }
            Console.WriteLine("the key does not exist");
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
        }
        public void Merge(LinkedList other_list)
        {
            if (this.First==null||other_list.First==null)
            {
                Console.WriteLine("you should fill the list befor");
            }
            Node move = this.First;
            // TODO: merge this list with the other list
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = other_list.First;
            other_list.First = this.First;
        }
        public void Reverse()
        {
            Node prev = null, next = null, current = First;
            while (current!=null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            First = prev;
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
        }
    }
}
