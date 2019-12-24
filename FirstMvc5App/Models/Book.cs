using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstMvc5App.Models
{
    public class Book
    {
        // ID книги
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        // название книги
        [DisplayName("Имя")]
        public string Name { get; set; }
        // автор книги
        [DisplayName("Автор")]
        public string Author { get; set; }
        // цена
        [DisplayName("Цена")]
        public int Price { get; set; }
    }
}