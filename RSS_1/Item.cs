//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSS_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int item_codigo { get; set; }
        public string item_url { get; set; }
        public string item_titulo { get; set; }
        public Nullable<bool> item_lido { get; set; }
        public string item_conteudo { get; set; }
        public Nullable<System.DateTime> item_dthr { get; set; }
        public Nullable<int> feed_codigo { get; set; }
    
        public virtual Feed Feed { get; set; }
    }
}
