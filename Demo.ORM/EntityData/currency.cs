using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class currency
    {
           public currency(){


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
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:兑换的货币
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int fromwallettype_id {get;set;}

           /// <summary>
           /// Desc:兑换为货币
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int towallettype_id {get;set;}

           /// <summary>
           /// Desc:兑换比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string bltext {get;set;}

           /// <summary>
           /// Desc:金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal fromamount {get;set;}

           /// <summary>
           /// Desc:兑换后金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal toamount {get;set;}

    }
}
