//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vinarija.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vino
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vino()
        {
            this.KolicinaVinoes = new HashSet<KolicinaVino>();
            this.Narackas = new HashSet<Naracka>();
            this.SostojkiVinoes = new HashSet<SostojkiVino>();
        }
    
        public string ImeVino { get; set; }
        public int VinoID { get; set; }
        public Nullable<int> TipVinoID { get; set; }
        public Nullable<int> ProizvoditelVinoID { get; set; }
        public Nullable<int> GodinaProizvdostvo { get; set; }
        public Nullable<int> Cena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KolicinaVino> KolicinaVinoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Naracka> Narackas { get; set; }
        public virtual ProizvoditelVino ProizvoditelVino { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SostojkiVino> SostojkiVinoes { get; set; }
        public virtual TipVino TipVino { get; set; }
    }
}
