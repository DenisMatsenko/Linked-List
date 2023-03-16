public class List {
    private Node? head, tail, current;
    private int count = 0;
    public int Count { get { return count; } }
    public bool IsEmpty() => count == 0;
    private void Reset() {
        head = null;
        tail = null;
        current = null;
        count = 0;
    }

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

    // ? Remove Node from list methods
    public void RemoveFirst() {
        // ? if list is empty
        if(IsEmpty()) {
            return;
        }
        // ? if list have only one element
        else if(Count == 1) {
            Reset();
        }
        else {
            head.Next.Prev = null;
            if(head == current) // ? if head is current
                current = head.Next;
            head = head.Next;
        }
        count--;
    }
    public void RemoveLast() {
        // ? if list is empty
        if(IsEmpty()) 
            return;
        // ? if list have only one element
        else if( Count == 1) {
            Reset();
        }
        else {
            tail.Prev.Next = null;
            if(tail == current) // ? if tail is current
                current = tail.Prev;
            tail = tail.Prev;
        }
        count--;
    }
    public void RemoveNext() {
        // ? if list is empty
        if(IsEmpty() && current == tail) 
            return;
        else if(current.Next != null) {
            current.Next = current.Next.Next; // ? set to current new next node
            if(current.Next != null)
                current.Next.Prev = current;
            else
                tail = current;
            count--;
        }   
    }
    public void RemovePrev() {
        // ? if list is empty or current is head
        if(IsEmpty() && current == head) 
            return;
        else if(current.Prev != null) {
            current.Prev = current.Prev.Prev; // ? set to current new prev node
            if(current.Prev != null)
                current.Prev.Next = current;
            else
                head = current;
            count--;
        }   
    }
    public void RemoveCurrent() {
        // ? if list is empty
        if(IsEmpty()) {
            return;
        }
        // ? if list have only one element
        else if(Count == 1) {
            Reset();
        }
        else if(current == head) {
            RemoveFirst();
        }
        else if(current == tail) {
            RemoveLast();
        }
        else {
            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
            current = current.Next;
            count--;
        }
        
    }

    // ? Show list methods
    public void ShowListData() {
        System.Console.WriteLine("Current:" + current + " Head:" + head + " Tail:" + tail + " Count:" + count);
    }
    public void ShowList() {
        if(Count == 0) {
            Global.SetConsoleColor(ConsoleColor.Red);
            System.Console.WriteLine("List is empty");
            Global.ResetConsoleColor();
            return;
        }

        for(Node node = head; node != null; node = node.Next) {
            if(current == node)
                Global.SetConsoleColor(ConsoleColor.Red); // ? Show current as red
            if(node != tail) {
                System.Console.Write(node.Data);
                Global.ResetConsoleColor(); // ? it is necessary be here
                System.Console.Write(" - ");
            }
            else
                System.Console.WriteLine(node.Data);
            Global.ResetConsoleColor();
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