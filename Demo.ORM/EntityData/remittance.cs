using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class remittance
    {
           public remittance(){


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
           /// Desc:金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal amount {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int wallettype_id {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? checkeddate {get;set;}

           /// <summary>
           /// Desc:收款账号cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string sysbankaccount_cid {get;set;}

           /// <summary>
           /// Desc:收款账号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string sysbankaccount {get;set;}

           /// <summary>
           /// Desc:汇款银行
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
           /// Desc:汇款时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime postdate {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
