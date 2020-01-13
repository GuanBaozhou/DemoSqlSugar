using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class tongjiusers
    {
           public tongjiusers(){


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
           /// Nullable:True
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:用户编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string users_code {get;set;}

           /// <summary>
           /// Desc:销售奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus1 {get;set;}

           /// <summary>
           /// Desc:领导奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus2 {get;set;}

           /// <summary>
           /// Desc:复消奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus3 {get;set;}

           /// <summary>
           /// Desc:分红奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus4 {get;set;}

           /// <summary>
           /// Desc:报单费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus5 {get;set;}

           /// <summary>
           /// Desc:产品积分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus6 {get;set;}

           /// <summary>
           /// Desc:专卖店推荐奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus7 {get;set;}

           /// <summary>
           /// Desc:销售奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus8 {get;set;}

           /// <summary>
           /// Desc:领导奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus9 {get;set;}

           /// <summary>
           /// Desc:复消奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus10 {get;set;}

           /// <summary>
           /// Desc:奖金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalbonus {get;set;}

           /// <summary>
           /// Desc:收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalshouru {get;set;}

           /// <summary>
           /// Desc:左区新增业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? leftaddgrade {get;set;}

           /// <summary>
           /// Desc:右区新增业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? rightaddgrade {get;set;}

           /// <summary>
           /// Desc:左区未结算业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? leftweigrade {get;set;}

           /// <summary>
           /// Desc:右区未结算业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? rightweigrade {get;set;}

           /// <summary>
           /// Desc:左区累积业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? leftsumgrade {get;set;}

           /// <summary>
           /// Desc:右区累积业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? rightsumgrade {get;set;}

           /// <summary>
           /// Desc:扣税
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? kousui {get;set;}

           /// <summary>
           /// Desc:转复消
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? fuxiao {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? displaytime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
