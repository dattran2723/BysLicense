using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class LoginDetailDto
    {
        public string ProjectCode { get; set; }

        public string UserName { get; set; }

        public string IPAddress { get; set; }

        public string PCName { get; set; }
    }
}
