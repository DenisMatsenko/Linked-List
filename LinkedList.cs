public class List {
    private Node? head, tail, current;
    private int count = 0;
    public int Count { get { return count; } }
    public bool IsEmpty() => count == 0;


    // ? Add Node to list methods
    public void AddFirst(Object item) {
        Node newNode = new Node(item);
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
        Node newNode = new Node(item); //* create a new node 

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
        Node newNode = new Node(item); //* create a new node

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
        
        Node newNode = new Node(item);
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
    // ? Show list methods
    public void ShowList() {
        for(Node node = head; node != null; node = node.Next) {
            if(node != tail)
                System.Console.Write(node.Data + " - ");
            else
                System.Console.WriteLine(node.Data);
        }
    }
    public void ShowFirst() {
        System.Console.WriteLine($"First: {(head == null ? "none" : head.Data)}");
    }
    public void ShowLast() {
        System.Console.WriteLine($"Last: {(tail == null ? "none" : tail.Data)}");
    }
    public void ShowPrev() {
        System.Console.WriteLine($"Prev: {(current.Prev == null? "none" : current.Prev.Data)}");
    }
    public void ShowNext() {
        System.Console.WriteLine($"Next: {(current.Next == null? "none" : current.Next.Data)}");
    }
    public void ShowCurrent() {
        System.Console.WriteLine($"Current: {(current == null? "none" : current.Data)}");
    }
}