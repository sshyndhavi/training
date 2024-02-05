using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Node
{
    public int data;
    public Node prev;
    public Node next;
    public Node(int d)
    {
        data = d;
        prev = null;
        next = null;
    }
}
public class HynduArraylist<T>
{
    public Node head;
    public Node tail;
    public HynduArraylist()
    {
        head = null;
        tail = null;
    }
    public void Insertfirst(int data)
    {
        Node obj = new Node(data);
        if (head == null)
        {
            head = obj;
            tail = obj;
        }
        else
        {
            obj.next = head;
            head.prev = obj;
            head = obj;
        }
    }
    public void Insertlast(int data)
    {
        Node obj = new Node(data);
        if (tail == null)
        {
            head = obj;
            tail = obj;
        }
        else
        {
            tail.next = obj;
            obj.prev = tail;
            tail = obj;
        }

    }

    public void Print()
    {
        Node currentnode = head;
        while (currentnode != null)
        {
            Console.Write(currentnode.data + " ");
            currentnode = currentnode.next;
        }


    }
    public int Count()
    {
        int count = 0;
        Node currentnode = head;
        while (currentnode != null)
        {
            count++;
            currentnode = currentnode.next;

        }
        return count;
    }
    public void RemoveLast( int data)
    {
        if (head == null)
        {
            Console.WriteLine("list is empty");
            return;
        }
        if (head == tail)
        {
            head = null;
            tail = null;
            return;
        }
        tail = tail.prev;
        tail.next = null;

    }
    public void RemoveFirst(int data)
    {
        if(head == null)
        {
            Console.WriteLine("list is empty");
            return;
        }
        if (head == tail)
        {
            head = null;
            tail = null;
            return;
        }
        head = head.next;
        head.prev = null;
    }
}



