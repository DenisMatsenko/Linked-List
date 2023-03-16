internal class Program
{
    private static void Main(string[] args)
    {
        List list = new List();

        list.AddFirst(1);
        list.AddPrev(2);
        list.AddFirst(3);
        list.AddNext(4);
        list.AddPrev(5);

        for (int i = 0; i < 6; i++)
        {
            list.ShowList();
            list.RemoveCurrent();
        }  
    }
}