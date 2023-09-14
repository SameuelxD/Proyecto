using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto
{
    public class linq_queries
    {
        List<book> listBooks = new List<book>();
        
        public linq_queries(){
            using(StreamReader reader = new StreamReader("books.json")){
                string json = reader.ReadToEnd();
                this.listBooks = System.Text.Json.JsonSerializer.Deserialize<List<book>>(json, new System.Text.Json.JsonSerializerOptions(){
                    PropertyNameCaseInsensitive = true }) ?? new List<book>();
                };
            }
        public IEnumerable<book> AllCollection(){
            return listBooks;   
        }
        public IEnumerable<book> LibrosDespuesDe2000(){
            return from book in listBooks where book.PublishedDate.Year > 2000 select book;
        }
        public IEnumerable<book> BuscarAndroid(){
            return from book in listBooks where book.Title.Contains("Android") select book;
        }
        public IEnumerable<book> Android2005(){
            return from book in listBooks where book.PublishedDate.Year > 2005 && book.Title.Contains("Android") select book;
        }
        public IEnumerable<book> Libros250Pag(){
            return from book in listBooks where book.Title.Contains("Action")  && book.PageCount > 250  select book;
        }
        public bool LibrosStatus(){
            return listBooks.All(book => book.Status != String.Empty);
        }
        public bool Libros2005(){
            return listBooks.Any(book => book.PublishedDate.Year == 2005);
        } 
        public IEnumerable<book> ListaLibros2005(){
            if(Libros2005()){
                return from book in listBooks where book.PublishedDate.Year == 2005 select book;
            }
            return new List<book>();
        }
    }
}