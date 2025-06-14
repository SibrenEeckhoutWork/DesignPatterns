﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class Book : IBookComponent
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Accept(IBookVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
