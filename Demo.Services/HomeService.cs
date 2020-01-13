using Demo.ORM;
using Demo.ORM.EntityData;
using System.Collections.Generic;

namespace Demo.Services
{
    public class HomeService : SqlSugarBase
    {
        public List<country> GetList()
        {
            


            return DB.Queryable<country>().Take(5).ToList();

        }


        public void cretaDBFirst()
        {

            DB.DbFirst.CreateClassFile(@"C:\Users\AdministratorG\source\repos\WebApplication1\Demo.ORM\EntityData\", "Demo.ORM.EntityData");

        }
    }
}
