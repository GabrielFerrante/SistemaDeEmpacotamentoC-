//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDeEmpacotamento
{
    using System;
    using System.Collections.Generic;
    
    public partial class materiai
    {
        public materiai()
        {
            this.pacotes = new HashSet<pacote>();
        }
    
        public int MAid { get; set; }
        public string nome { get; set; }
    
        public virtual ICollection<pacote> pacotes { get; set; }
    }
}