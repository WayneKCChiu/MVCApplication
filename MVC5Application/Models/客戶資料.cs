//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5Application.Models
{
   using System;
   using System.Collections.Generic;
   using System.ComponentModel.DataAnnotations;
   public partial class 客戶資料
   {
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public 客戶資料() {
         this.客戶銀行資訊 = new HashSet<客戶銀行資訊>();
         this.客戶聯絡人 = new HashSet<客戶聯絡人>();
      }

      [Required]
      public int Id { get; set; }
      [Required]
      public string 客戶名稱 { get; set; }
      [Required]
      public string 統一編號 { get; set; }
      [Required]
      [其中必須有一個dash]
      public string 電話 { get; set; }
      [Required]
      public string 傳真 { get; set; }
      [Required]
      public string 地址 { get; set; }
      [Required]
      [RegularExpression( @"(@)(.+)$")]
      public string Email { get; set; }
      public bool IsDelete { get; set; }

      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
   }
}
