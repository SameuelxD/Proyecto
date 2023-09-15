using System.Linq;

using Proyecto;

internal class Program
{
    private static void Main(string[] args){
        int[] args2= new int[5];
        Console.WriteLine(args2[0]);
        linq_queries queries = new linq_queries();
        /*Console.WriteLine(queries.LibrosStatus() ? "Todos los libros contienen status" : "Almenos uno de los libros no contiene status");*/
        //ImprimirValores(queries.ListaLibros2005());
        Console.WriteLine(queries.Coincidencias());

    }
    private static void ImprimirValores(IEnumerable<book> books)
    {
        int registros = 0;
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}" , "Titulo", "N. Paginas", "Fecha Publicacion");
        foreach (book book in books){
            Console.ForegroundColor=ConsoleColor.Yellow;
            registros+=1;
            Console.WriteLine("{0,-70} {1,7} {2,20}" , book.Title , book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }
    
}