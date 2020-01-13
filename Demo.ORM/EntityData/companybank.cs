using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class companybank
    {
           public companybank(){


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
           /// Nullable:False
           /// </summary>           
           public string cid {get;set;}

           /// <summary>
           /// Desc:银行名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string bank {get;set;}

           /// <summary>
           /// Desc:卡号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string cardcode {get;set;}

           /// <summary>
           /// Desc:户主
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string cardusername {get;set;}

           /// <summary>
           /// Desc:是否删除
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? isdelete {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
