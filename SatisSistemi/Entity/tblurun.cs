//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatisSistemi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblurun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblurun()
        {
            this.tblsatisdetay = new HashSet<tblsatisdetay>();
        }
    
        public int id { get; set; }
        public string ad { get; set; }
        public string marka { get; set; }
        public string barkod { get; set; }
        public Nullable<int> olcubirimi { get; set; }
        public Nullable<double> birimfiyat { get; set; }
        public Nullable<int> kdvorani { get; set; }
        public Nullable<int> stokmiktari { get; set; }
        public Nullable<int> uyarimiktari { get; set; }
        public Nullable<int> sil_id { get; set; }
        public Nullable<System.DateTime> ekleme_tarihi { get; set; }
        public Nullable<System.DateTime> guncelleme_tarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatisdetay> tblsatisdetay { get; set; }
    }
}
