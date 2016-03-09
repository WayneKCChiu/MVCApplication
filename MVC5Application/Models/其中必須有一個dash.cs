using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Application.Models
{
   public class 其中必須有一個dash : DataTypeAttribute
   {
      public 其中必須有一個dash():base(DataType.Text) {
      }

      public override bool IsValid(object value) {
         var str = (string)value;

         return str.Contains("-");
      }
   }
}