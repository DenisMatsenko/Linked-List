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
        else
            tail = newNode;

        head = newNode;
        current = newNode;
        count++;
    }

    public void AddNext(Object item) {
        Node newNode = new Node(); //* create a new node
        newNode.Data = item; //* select data to the new node

        //right side
        newNode.Next = current.Next; //* new => right
        if(current.Next != null) //* if have right node
            current.Next.Prev = newNode; //* new <= right
        else
            tail = newNode; //* select new to tail

        //left side
        current.Next = newNode; //* left => new
        newNode.Prev = current; //* left <= new

        current = newNode; //* select new as current
        count++; //* increase count
    }

    public void AddPrev(Object item) {
        Node newNode = new Node(); //* create a new node
        newNode.Data = item; //* select data to the new node

        //left side
        newNode.Prev = current.Prev; //* new => left
        if(current.Prev != null) //* if have left node
            current.Prev.Next = newNode; //* new <= left
        else
            head = newNode; //* select new to head

        //right side
        current.Prev = newNode; //* right => new
        newNode.Next = current; //* right <= new

        current = newNode; //* select new as current
        count++; //* increase count
    }

    
    public void AddLast(Object item) {
        Node newNode = new Node();
        newNode.Data = item;
        newNode.Prev = tail;

        if(tail != null)
            tail.Next = newNode;
        else
            head = newNode;

        tail = newNode;
        current = newNode;
        count++;
    }

    //todo RemoveFirst, RemoveLast, RemovePrev, RemoveNext, RemoveCurrent
    //todo ShowFirst, ShowLast, ShowPrev, ShowNext, ShowCurrent

    private class Node {
    public Node Prev { get; set; }
    public Node Next { get; set; }
    public Object Data { get; set; }
    }
    
}

