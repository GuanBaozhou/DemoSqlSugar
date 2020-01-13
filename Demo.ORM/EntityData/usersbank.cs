using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class usersbank
    {
           public usersbank(){


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
           /// Desc:用户cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_code {get;set;}

           /// <summary>
           /// Desc:银行
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string bank {get;set;}

           /// <summary>
           /// Desc:支行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string subbank {get;set;}

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
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool isdefault {get;set;}

    }
}
