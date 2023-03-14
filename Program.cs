internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}

public class List {
    private Node head, tail, current;
    private int count = 0;
    public int Count { get { return count; } }
    public bool IsEmpty() {
        return count == 0;
    }

    public void AddFirst(Object item) {
        Node newNode = new Node();
        newNode.Data = item;
        newNode.Next = head;

        if(head != null)
            head.Prev = newNode;
        else if (head == null)
            tail = newNode;

        head = newNode;
        current = newNode;
        count++;
    }

    public void AddNext(Object item) {
        Node newNode = new Node(); //* create a new node
        newNode.Data = item; //* select data to the new node

        newNode.Next = current.Next; //* new => right
        current.Next = newNode; //* left => new
        newNode.Prev = current; //* left <= new

        if(current.Next != null) //* if have right node
            current.Next.Prev = newNode; //* new <= right
        else
            tail = newNode; //* select new to tail

        current = newNode; //* select new as current
        count++; //* increase count
    }

    private class Node {
    public Node Prev { get; set; }
    public Node Next { get; set; }
    public Object Data { get; set; }
    }
    
}

