//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrPract1._1
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMP
    {
        public int ID_EMP { get; set; }
        public string SURNAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLENAME { get; set; }
        public Nullable<int> Clients_ID { get; set; }
    
        public virtual Clients Clients { private get; set; }
    }
}
