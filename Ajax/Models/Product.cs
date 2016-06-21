using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class Product
    {
        //public int ProductId { get; set; }
        public string ProdCode
        {
            get;
            set;
        }
        public string ProdName
        {
            get;
            set;
        }
        public int ProdQty
        {
            get;
            set;
        }
    }
}