//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reklamacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reklamacija()
        {
            this.Odgovor = new HashSet<Odgovor>();
        }
    
        public int IDReklamacija { get; set; }
        public int IDProizvod { get; set; }
        public int IDKorisnik { get; set; }
        public System.DateTime Datum { get; set; }
        public string Opis { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odgovor> Odgovor { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
