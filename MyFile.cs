using System;
using System.Collections.Generic;

namespace EntityDbFirst
{
    public partial class TblProducts
    {
        
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }

        public virtual TblCategories Category { get; set; }

        public string Siraj { get;set; }
        public string MyFile { get;set; }
    }
}
