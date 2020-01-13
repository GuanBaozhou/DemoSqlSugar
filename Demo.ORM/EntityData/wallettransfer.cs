using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class wallettransfer
    {
           public wallettransfer(){


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
           /// Desc:转出货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? fromwallettype_id {get;set;}

           /// <summary>
           /// Desc:转入货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? towallettype_id {get;set;}

           /// <summary>
           /// Desc:转出货币比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? fromrate {get;set;}

           /// <summary>
           /// Desc:转入货币比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? torate {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
