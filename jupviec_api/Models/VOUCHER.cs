//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jupviec_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VOUCHER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VOUCHER()
        {
            this.DONDATDICHVUs = new HashSet<DONDATDICHVU>();
        }
    
        public string MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public int SoTien { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgayApDung { get; set; }
        public System.DateTime NgayHet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATDICHVU> DONDATDICHVUs { get; set; }
    }
}
