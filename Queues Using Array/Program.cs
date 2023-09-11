using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Using_Array
{
    internal class Program
    {
        class QueuesUsingArray
        {
            int[] data;
            int front;
            int rear;
            int size;
            public QueuesUsingArray(int n) 
            {
                data = new int[n];
                front = 0;
                rear = 0;
                size = 0;
            }
            public int length()
            {
                return size;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public bool isFull()
            {
                return size == data.Length;
            }
            public void enqueue(int e) 
            {
                if (isFull())
                {
                    Console.WriteLine("Queue is full");
                    return;
                }
                else
                {
                    data[rear] = e;
                    rear++;
                    size++;
                }
                
            }
            public int dequeue()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                int e = data[front];
                front++;
                size--;
                return e;
            }
            public int First()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                else
                {
                    return data[front];
                }
            }
            public void display()
            {
                for(int i = front; i<rear; i++)
                {
                    Console.WriteLine(data[i]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            QueuesUsingArray Q = new QueuesUsingArray(6);
            Console.WriteLine("Creating a Queue of size 6: enqueue()");
            Q.enqueue(1);
            Q.enqueue(2);
            Q.enqueue(3);
            Q.enqueue(4);
            Q.enqueue(5);
            Q.enqueue(6);
            Q.display();
            Console.WriteLine("Size:" + Q.length());
            
            Console.WriteLine();
            Console.WriteLine("Removing first elemnet of Queue (FIFO): dequeue()");
            Q.dequeue();
            Q.display();
            Console.WriteLine("Size:" + Q.length());
            Console.WriteLine();
            Console.WriteLine("Finding First element : First() --> "+Q.First() );
            



            Console.ReadLine();


        }
    }
}
