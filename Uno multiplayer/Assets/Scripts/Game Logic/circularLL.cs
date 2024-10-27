using System;

public class CircularLinkedList<T>
{
    public class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public Node head;
    public Node tail;

    public CircularLinkedList()
    {
        head = null;
        tail = null;
    }

    // Add a node to the end of the list
    public void Add(T data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            newNode.Next = head;  // Point to head to make it circular
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;  // Maintain circularity
        }
    }

    // Traverse the list
    public void Traverse()
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        Node current = head;
        do
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        } while (current != head); // Circular condition
    }

    // Check if the list is circular
    public bool IsCircular()
    {
        if (head == null)
        {
            return false;
        }

        Node current = head;
        while (current.Next != null && current.Next != head)
        {
            current = current.Next;
        }

        return current.Next == head;
    }
}
public class Player
{
    public string Name;
    public int PlayerID;
    public bool IsTurn;

    public Player(string name, int id)
    {
        Name = name;
        PlayerID = id;
        IsTurn = false;
    }
}