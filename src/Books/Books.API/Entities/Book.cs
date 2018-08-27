using System;

namespace Books.API.Entities
{
    public class Book {
        public Guid Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Autor
        {
            get;
            set;
        }
    }
}
