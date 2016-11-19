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
    
    public partial class FuelExpense
    {
        public int Id { get; set; }
        public int FarmId { get; set; }
        public int AreaId { get; set; }
        public int CropId { get; set; }
        public int FuelId { get; set; }
        public string PersonName { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public int UserId { get; set; }
    
        public virtual CropManagement CropManagement { get; set; }
        public virtual Farm Farm { get; set; }
        public virtual FarmArea FarmArea { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
    }
}