//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int product_id { get; set; }
        public int warehouse_id { get; set; }
        public decimal quantity_on_hand { get; set; }
    
        public virtual ProductInformation ProductInformation { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
