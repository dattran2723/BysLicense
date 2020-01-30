using Data.Dtos;
using Data.Entities;
using Data.Reponsitories;
using Services.Implementations.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ProjectService
    {
        private readonly ProjectReponsitory _projectReponsitory;
        private readonly LoginDetailReponsitory _loginDetailReponsitory;
        private readonly LicenseReponsitory _licenseReponsitory;

        public ProjectService()
        {
            _projectReponsitory = new ProjectReponsitory();
            _loginDetailReponsitory = new LoginDetailReponsitory();
            _licenseReponsitory = new LicenseReponsitory();
        }

        public LicenseDto GetLicense(LoginDetailDto dto)
        {
            var project = _projectReponsitory.GetProjectByCode(dto.ProjectCode);
            if (project == null)
            {
                throw new Exception("Project not found!");
            }

            var loginDetail = _loginDetailReponsitory.Save(dto.ToLoginDetail(project.Id));
            var license = _licenseReponsitory.GetByProject(project.Id);
            return license.ToLicenseDto();
        }
    }
}
