using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity
    {
        public int Id{get;set;}
         [AllowNull]  
        public bool? Status{get;set;}
        [AllowNull]      
          public string Remarks{get;set;}
    }
}