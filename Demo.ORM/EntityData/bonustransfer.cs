using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class bonustransfer
    {
           public bonustransfer(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:奖金类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus {get;set;}

           /// <summary>
           /// Desc:左值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? leftvalue {get;set;}

           /// <summary>
           /// Desc:右值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? rightvalue {get;set;}

           /// <summary>
           /// Desc:对碰值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? duipengvalue {get;set;}

    }
}
