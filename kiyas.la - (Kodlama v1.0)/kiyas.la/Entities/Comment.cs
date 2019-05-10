using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiyas.la.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Yorum { get; set; }

        public string Name { get; set; }

        public Phone Product { get; set; }

        public int ProductId { get; set; }

        public DateTime Time { get; set; }

        public string randomphoto { get; set; }
    }
}