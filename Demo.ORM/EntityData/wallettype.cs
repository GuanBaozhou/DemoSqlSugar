using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class wallettype
    {
           public wallettype(){


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
           /// Desc:货币名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:是否可以外部转账
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? istransfer {get;set;}

           /// <summary>
           /// Desc:是否可以提现
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? iscash {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isremittance {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
