//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;

    public partial class Kullanici
    {
        public System.Guid ID { get; set; }

        [Required(ErrorMessage = "Bu alan gerekli!")]
        [Display(Name = "Kullan?c? Ad?")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Bu alan gerekli!")]
        [Display(Name = "?ifre")]
        public string Sifre { get; set; }
    }
}
