using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class bonusdetail
    {
           public bonusdetail(){


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
           /// Desc:账目
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? balance_id {get;set;}

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
           /// Desc:奖金来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string descript {get;set;}

           /// <summary>
           /// Desc:结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? money {get;set;}

           /// <summary>
           /// Desc:实际获得金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? realmoney {get;set;}

           /// <summary>
           /// Desc:奖金类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? bonustype_id {get;set;}

           /// <summary>
           /// Desc:报单币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet1 {get;set;}

           /// <summary>
           /// Desc:奖金币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet2 {get;set;}

           /// <summary>
           /// Desc:重消币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet3 {get;set;}

           /// <summary>
           /// Desc:复投币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet4 {get;set;}

           /// <summary>
           /// Desc:红利币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet5 {get;set;}

           /// <summary>
           /// Desc:提货币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet6 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet7 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet8 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet9 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet10 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet11 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet12 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet13 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet14 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? wallet15 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? displaytime {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
