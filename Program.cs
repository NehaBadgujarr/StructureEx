using System;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {
        Books Book1;   /* Declare Book1 of type Book */
        Books Book2;   /* Declare Book2 of type Book */

        /* book 1 specification */
        Book1.title = "C# Programming";
        Book1.author = "DR.N.K.Sinha";
        Book1.subject = "C# Programming Tutorial";
        Book1.book_id = 12345;

        /* book 2 specification */
        Book2.title = "JAVA Programming";
        Book2.author = "B.K.Pathak";
        Book2.subject = "JAVA Tutorial";
        Book2.book_id = 54321;

        /* print Book1 info */
        Console.WriteLine("Book 1 title : {0}", Book1.title);
        Console.WriteLine("Book 1 author : {0}", Book1.author);
        Console.WriteLine("Book 1 subject : {0}", Book1.subject);
        Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);
        Console.WriteLine("-----------------------------------------------------------------");

        /* print Book2 info */
        Console.WriteLine("Book 2 title : {0}", Book2.title);
        Console.WriteLine("Book 2 author : {0}", Book2.author);
        Console.WriteLine("Book 2 subject : {0}", Book2.subject);
        Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

        Console.ReadKey();
    }
}
