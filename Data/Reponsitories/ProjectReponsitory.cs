using Data.DataContext;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reponsitories
{
    public class ProjectReponsitory
    {
        public Project GetProjectByCode(string code)
        {
			try
			{
				using(DataRepositoryContext db = new DataRepositoryContext())
				{
					var project = db.Database.SqlQuery<Project>(@"GetProjectByCode @Code",
						new SqlParameter("Code", code)).FirstOrDefault();
					return project;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
