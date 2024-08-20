﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Reader
    {
        private string id;
        private string name;
        private List<Book> books;


        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }


        public Reader(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.books = new List<Book>();
        }
    }
}
