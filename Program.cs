using System;
using System.Collections.Generic;

namespace Week2Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine($"Is it empty before we pushing? : {s.IsEmpty()}");
            s.Push("12");
            Console.WriteLine($"After Pushing   the last data is {s.Peek()}");
            s.Push("Hello");
            Console.WriteLine($"Size of the Stack is{s.Size()}");
            Console.WriteLine($"After Pushing Hello, the first data is {s.Peek()}");
            s.Pop();
            Console.WriteLine($"After Poping, the first data is {s.Peek()}");
            s.Push("Dear");
            Console.WriteLine($"Size of the Stack is{s.Size()}");
            s.Push("Reader");
            Console.WriteLine($"After Pushing 18 and 25 the first data is {s.Peek()}");
            Console.WriteLine($"Size of the Stack is{s.Size()}");



            //Queue q = new Queue();
            //Console.WriteLine($"Is it empty before we enque? : {q.IsEmpty()}");
            //q.enqueue(10);
            //Console.WriteLine($"After Enqueing 10 the first data is {q.first.key}");
            //Console.WriteLine($"After Enqueing 10 the last data is {q.last.key}");
            //q.enqueue(20);
            //Console.WriteLine($"After Enqueing 10 the first data is {q.first.key}");
            //Console.WriteLine($"After Enqueing 20 the last data is {q.last.key}");
            //q.dequeue();
            //Console.WriteLine($"After Dequeing the first data is {q.first.key}");
            //Console.WriteLine($"After Dequeing the last data is {q.last.key}");
            //q.enqueue(30);
            //q.enqueue(40);
            //Console.WriteLine($"After Enqueing 30 and 40 the first data is {q.first.key}");
            //Console.WriteLine($"After  Enqueing 30 and 40  the last data is {q.last.key}");
            //Console.WriteLine($"Is it empty? : {q.IsEmpty()}");
        }
    }



    public class StackNode
    {
        public StackNode Key;
        public string data;
    }
    class Stack
    {
        public StackNode top;
        public int count;

        // private List<StackNode> listStack;

        public Stack()
        {
            this.top = null;
            this.count = 0;
        }

        public bool IsEmpty()
        {
            return (top == null) ? true : false;
        }
        public void Push(string data)
        {
            StackNode tempo = new StackNode();
            if (tempo == null)
            {
                return;
            }

            tempo.data = data;
            this.count++;

            tempo.Key = top = tempo;
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Nothing in stack");
            }
            else
            {
                top = top.Key;
                // Reduce size
                this.count--;
            }
        }

        public string Peek()
        {
            return (IsEmpty()) ? $"Nothing is in the stack{-1}" : top.data;
        }

        public int Size()
        {

            return this.count;
        }
    }



    class QueNode
    {
        public int data;
        public QueNode next;
        public int count;

        // constructor to create a new linked list node
        public QueNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class Queue
    {
        public QueNode first;
        public QueNode last;
        public int count;

        public Queue()
        {
            this.first = this.last = null;
            this.count = 0;
        }

        public bool IsEmpty()
        {
            if (this.count== 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public void enqueue(int key)
        {
            QueNode newData = new QueNode(key);
           // this will make the first value to be in both rear and front
            if (this.count == 0)
            {
                this.first = this.last = newData;
                return;
            }

            this.count++;
            this.last.next = newData;//This takes the new newData
            this.last = newData;//This makes the taken newData to be the Last

        }
        public void dequeue()
        {


            if (this.count == 0)//This Check if the list is empty
            {
                Console.WriteLine("Empty Queue");
                return;
            }

            QueNode tempo = this.first;
            this.first = this.first.next;

            if (this.first == null)
            {
                this.last = null;
                this.count--;
            }

           
        }

        public int size()
        {
            return this.count;
        }


    }

    public class ListNode
    {
        public ListNode Key;
        public string data;
    }
    class List
    {
        public static void list()
        {

        }
        public static void isEmpty()
        {
            
        }

    }
}
