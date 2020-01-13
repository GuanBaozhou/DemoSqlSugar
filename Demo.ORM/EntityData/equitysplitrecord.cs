using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class equitysplitrecord
    {
           public equitysplitrecord(){


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
           /// Desc:拆分之前的价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? oldprice {get;set;}

           /// <summary>
           /// Desc:拆分之后的价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? newprice {get;set;}

           /// <summary>
           /// Desc:拆分之前的总数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? oldcount {get;set;}

           /// <summary>
           /// Desc:拆分之后的总数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? newcount {get;set;}

           /// <summary>
           /// Desc:拆分的倍率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? rate {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
