using Data.Dtos;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations.Helpers
{
    public static class EntityToDtoConvertHelper
    {
        public static LicenseDto ToLicenseDto(this License entity)
        {
            return entity == null
                ? null
                : new LicenseDto
                {
                    IsActive = entity.IsActive,
                    WorkingMode = entity.WorkingMode,
                    TransactionTime = entity.TransactionTime
                };
        }
    }
}
