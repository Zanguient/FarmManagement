//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OtherItem
    {
        public OtherItem()
        {
            this.OtherExpenses = new HashSet<OtherExpense>();
        }
    
        public int ItemId { get; set; }
        public int FarmId { get; set; }
        public string TitleExpense { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public System.DateTime DatePurchase { get; set; }
        public System.DateTime InsertDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int AccountId { get; set; }
        public int UserId { get; set; }
    
        public virtual Farm Farm { get; set; }
        public virtual ICollection<OtherExpense> OtherExpenses { get; set; }
        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
    }
}