using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class bonustype
    {
           public bonustype(){


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
           /// Desc:奖金名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:结算类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:发放状态,0是正常发放,1是暂停发放
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string holiday {get;set;}

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
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
