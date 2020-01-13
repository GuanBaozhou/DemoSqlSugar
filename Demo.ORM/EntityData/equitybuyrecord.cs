using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class equitybuyrecord
    {
           public equitybuyrecord(){


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
           /// Nullable:False
           /// </summary>           
           public string selluserscode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string selluserscid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string buyuserscode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string buyuserscid {get;set;}

           /// <summary>
           /// Desc:购买总数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal count {get;set;}

           /// <summary>
           /// Desc:购买单价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal price {get;set;}

           /// <summary>
           /// Desc:混合支付方式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string paymethod {get;set;}

           /// <summary>
           /// Desc:需要支付的总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal mustmoney {get;set;}

           /// <summary>
           /// Desc:挂买单cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string buyguadancid {get;set;}

           /// <summary>
           /// Desc:挂卖单cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sellguadancid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string serialnumber {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
