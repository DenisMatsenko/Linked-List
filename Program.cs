internal class Program
{
    private static void Main(string[] args)
    {
        //? Example
        List list = new List();

        list.AddFirst(1);
        list.AddPrev(2);
        list.AddNext(3);

        list.ShowList(); 

        list.RemoveFirst();
        list.RemoveCurrent();

        list.ShowList(); 
    }
}