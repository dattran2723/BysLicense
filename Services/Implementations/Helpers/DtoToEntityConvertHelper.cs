using Data.Dtos;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations.Helpers
{
    public static class DtoToEntityConvertHelper
    {
        public static LoginDetail ToLoginDetail(this LoginDetailDto dto, Guid projectId)
        {
            return new LoginDetail
            {
                Id = Guid.NewGuid(),
                ProjectId = projectId,
                UserName = dto.UserName,
                IPAddress = dto.IPAddress,
                PCName = dto.PCName,
                CreatedDate = DateTime.Now
            };
        }
    }
}
