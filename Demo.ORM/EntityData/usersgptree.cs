﻿using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class usersgptree
    {
           public usersgptree(){


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
           /// Nullable:True
           /// </summary>           
           public string gpusers_cid {get;set;}

           /// <summary>
           /// Desc:下级用户cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string childcid {get;set;}

           /// <summary>
           /// Desc:公排位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? position {get;set;}

           /// <summary>
           /// Desc:公排等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? level {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
