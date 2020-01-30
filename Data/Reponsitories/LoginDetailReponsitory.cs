using Data.DataContext;
using Data.Entities;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Reponsitories
{
	public class LoginDetailReponsitory
    {
        public LoginDetail Save(LoginDetail entity)
        {
			try
			{
				using (DataRepositoryContext db = new DataRepositoryContext())
				{
					var loginDetail = db.Database.SqlQuery<LoginDetail>(@"LoginDetailSave @Id, @ProjectId, @UserName, @IPAddress, @PCName, @CreatedDate, @UpdatedDate",
						new SqlParameter("Id", entity.Id),
						new SqlParameter("ProjectId", entity.ProjectId),
						new SqlParameter("UserName", entity.UserName ?? (object)DBNull.Value),
						new SqlParameter("IPAddress", entity.IPAddress ?? (object)DBNull.Value),
						new SqlParameter("PCName", entity.PCName ?? (object)DBNull.Value),
						new SqlParameter("CreatedDate", entity.CreatedDate),
						new SqlParameter("UpdatedDate", entity.UpdatedDate ?? (object)DBNull.Value)).FirstOrDefault();
					return loginDetail;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
