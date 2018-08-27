using System;
using System.Collections.Generic;
using System.Linq;
using Books.API.Entities;

namespace Books.API.Repositories
{
    public interface IBooksRepository{
        IEnumerable<Book> GetBooks();
        Book GetBookById(Guid id);
    }

    public class BooksRepository: IBooksRepository
    {
        private readonly List<Book> _books;

        public BooksRepository()
        {
            _books = new List<Book> {
                new Book { Id = Guid.Parse("c1b69fc5-9054-420e-b9fd-c1a1057b306f"), Name = "Blood Communion: A Tale of Prince Lestat", Autor = "Anne Rice"},
                new Book { Id = Guid.Parse("1c135226-7232-470d-9ba8-904bb4ec4f1e"), Name = "Dawn Of The Vampire Revived: 25th+ Anniversay Revised", Autor = "William Hill"},
                new Book { Id = Guid.Parse("dd369b65-57a6-4f4d-8597-dadca5f19fd9"), Name = "The Outsider", Autor = "Stephen King"},
                new Book { Id = Guid.Parse("77dee692-35f7-4625-8869-0e24e2e6d518"), Name = "Behind Closed Doors", Autor = "B.A. Paris"},
                new Book { Id = Guid.Parse("6c619561-583c-418e-b440-9193b1674b2a"), Name = "The Retreat", Autor = "Mark Edwards"},
                new Book { Id = Guid.Parse("c74bd238-1cb2-43a3-9d3e-e8eaac54488f"), Name = "The Last Time I Lied", Autor = "Riley Sager"},
            };
        }

        public IEnumerable<Book> GetBooks(){
            return _books;
        }

        public Book GetBookById(Guid id){
            return _books.FirstOrDefault(b => b.Id == id);
        }
    }
}
