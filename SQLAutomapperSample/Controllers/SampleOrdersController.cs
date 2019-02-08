using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using SQLAutomapperSample.DataAccess;
using SQLAutomapperSample.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace SQLAutomapperSample.Controllers
{
    [Produces("application/json")]
    [Route("api/sampleorders")]
    public class SampleOrdersController : Controller
    {
        private readonly SampleContext context;
        private readonly IMapper mapper;
        private readonly AutoMapper.IConfigurationProvider autoMapper;

        public SampleOrdersController(SampleContext context, IMapper mapper, AutoMapper.IConfigurationProvider autoMapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.autoMapper = autoMapper;
        }

        // GET api/sampleOrders
        [HttpGet]
        public ActionResult<IEnumerable<SampleOrderDto>> Get()
        {
            var orders = context.SampleOrderDbSet.ProjectTo<SampleOrderDto>(autoMapper).ToList();

            return Ok(orders);
        }
    }
}
