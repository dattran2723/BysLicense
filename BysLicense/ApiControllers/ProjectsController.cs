using Data.Dtos;
using Services.Implementations;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BysLicense.ApiControllers
{
    public class ProjectsController : ApiController
    {
        private readonly ProjectService _projectService;
        public ProjectsController()
        {
            _projectService = new ProjectService();
        }

        [Route("api/license")]
        [HttpPost]
        public HttpResponseMessage GetLicense([FromBody] LoginDetailDto dto)
        {
            var response = new BaseResponse<LicenseDto>
            {
                Status = true
            };
            try
            {
                response.Data = _projectService.GetLicense(dto);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                response.Error = new Error(ex.Message);
                response.Status = false;
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }
        }
    }
}
