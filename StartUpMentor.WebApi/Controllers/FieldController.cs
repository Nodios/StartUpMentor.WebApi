using StartUpMentor.Common.Filters;
using StartUpMentor.Service.Common;
using StartUpMentor.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StartUpMentor.WebApi.Controllers
{
    [RoutePrefix("api/field")]
    public class FieldController : ApiController
    {
        protected IFieldService Service { get; private set; }

        public FieldController(IFieldService service)
        {
            Service = service;
        }

        #region Get
        [HttpGet, Route("getById/{id}")]
        public async Task<HttpResponseMessage> Get(Guid id)
        {
            try
            {
                FieldModel result = AutoMapper.Mapper.Map<FieldModel>(await Service.GetAsync(id));

                if (result == null) return Request.CreateResponse(HttpStatusCode.BadRequest, "Cannot get requested field.");

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet, Route("{pageNumber}/{pageSize}")]
        public async Task<HttpResponseMessage> Get(int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                if(pageNumber < 1 || pageSize < 1)
                {
                    pageSize = 1;
                    pageNumber = 1;
                }

                GenericFilter filter = new GenericFilter(pageNumber, pageSize);

                IEnumerable<FieldModel> result = AutoMapper.Mapper.Map<IEnumerable<FieldModel>>(await Service.GetRangeAsync(filter));

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
