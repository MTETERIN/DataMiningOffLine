//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Helper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Measurements
    {
        public Nullable<long> param_id { get; set; }
        public Nullable<long> order_id { get; set; }
        public string time_st { get; set; }
        public long id { get; set; }
        public Nullable<double> value { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Parameters Parameters { get; set; }
    }
}
