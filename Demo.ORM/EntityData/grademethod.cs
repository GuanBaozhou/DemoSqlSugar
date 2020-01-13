using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class grademethod
    {
           public grademethod(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:newid()
           /// Nullable:True
           /// </summary>           
           public string cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:是否算业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? isgrade {get;set;}

           /// <summary>
           /// Desc:是否更新左右值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? isupdlr {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
