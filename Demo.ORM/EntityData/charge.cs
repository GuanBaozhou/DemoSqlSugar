using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class charge
    {
           public charge(){


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
           /// Nullable:True
           /// </summary>           
           public string users_code {get;set;}

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
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? checkeddate {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
