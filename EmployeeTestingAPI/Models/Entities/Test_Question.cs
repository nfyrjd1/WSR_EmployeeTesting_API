//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeTestingAPI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test_Question
    {
        public int ID_Test_Question { get; set; }
        public int ID_Test { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Nullable<int> Points { get; set; }
    
        public virtual Test Test { get; set; }
    }
}
