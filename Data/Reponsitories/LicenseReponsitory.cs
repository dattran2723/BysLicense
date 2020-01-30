using Data.DataContext;
using Data.Entities;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Reponsitories
{
	public class LicenseReponsitory
    {
        public License GetByProject(Guid projectId)
        {
			try
			{
				using (DataRepositoryContext db = new DataRepositoryContext())
				{
					var license = db.Database.SqlQuery<License>(@"GetLicenseByProjectId @ProjectId",
						new SqlParameter("ProjectId", projectId)).FirstOrDefault();

					return license;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
