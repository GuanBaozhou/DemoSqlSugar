using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class bonustemp
    {
           public bonustemp(){


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
           /// Desc:是否空单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? iskongdan {get;set;}

           /// <summary>
           /// Desc:用户等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string level_cid {get;set;}

           /// <summary>
           /// Desc:用户业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? registerlevelgrade {get;set;}

           /// <summary>
           /// Desc:接点人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jdusercid {get;set;}

           /// <summary>
           /// Desc:接点位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? jdposition {get;set;}

           /// <summary>
           /// Desc:接点等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? jdlevel {get;set;}

           /// <summary>
           /// Desc:推荐人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tjusercid {get;set;}

           /// <summary>
           /// Desc:对碰左值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? leftvalue {get;set;}

           /// <summary>
           /// Desc:对碰右值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? rightvalue {get;set;}

           /// <summary>
           /// Desc:对碰值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? duipengvalue {get;set;}

           /// <summary>
           /// Desc:对碰奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus1 {get;set;}

           /// <summary>
           /// Desc:直推奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus2 {get;set;}

           /// <summary>
           /// Desc:代数奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus3 {get;set;}

           /// <summary>
           /// Desc:报单奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus4 {get;set;}

           /// <summary>
           /// Desc:报单奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus6 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus7 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus8 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus9 {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:账目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? balance_id {get;set;}

           /// <summary>
           /// Desc:通过时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? activatedate {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
