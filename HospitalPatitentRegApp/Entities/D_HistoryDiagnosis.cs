//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalPatitentRegApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class D_HistoryDiagnosis
    {
        public int Patient { get; set; }
        public int Diagnosis { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Description { get; set; }
    
        public virtual D_Diagnosis D_Diagnosis { get; set; }
        public virtual D_Patient D_Patient { get; set; }
    }
}
