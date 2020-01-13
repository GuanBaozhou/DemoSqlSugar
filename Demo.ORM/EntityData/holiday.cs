using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class holiday
    {
           public holiday(){


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
           /// Desc:假日名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string holidayname {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime starttime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime endtime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
