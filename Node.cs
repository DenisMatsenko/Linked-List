public class Node {
    public Node? Prev { get; set; }
    public Node? Next { get; set; }
    public Object Data { get; set; }

    public Node(Object Data)
    {
        this.Data = Data;
    }
}