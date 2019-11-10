using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Library_01
{
       public static class Extention
    {
           public static object vSafe(this object obj)
           {
               if(obj== DBNull.Value)
               {
                   return null;
               }
               return obj;
           }
           public static object sToSqlValues(this object obj)
           {
               if (obj == null)
               {
                   return "";
               }
               return obj;

    }
         
    }
}
