using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class transfer
    {
           public transfer(){


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
           /// Desc:转出用户cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string fromusers_cid {get;set;}

           /// <summary>
           /// Desc:转出用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string fromusers_code {get;set;}

           /// <summary>
           /// Desc:转入用户cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string tousers_cid {get;set;}

           /// <summary>
           /// Desc:转入用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string tousers_code {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int wallettype_id {get;set;}

           /// <summary>
           /// Desc:金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal amount {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
