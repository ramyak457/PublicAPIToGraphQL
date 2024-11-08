using GraphQL.Types;
using GraphQL;
using Microsoft.AspNetCore.Mvc;
using VaccinationAPI.Schemas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VaccinationAPI.Controllers
{
    [Route("api/pop1")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        // GET: api/<GraphQLController>
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        public GraphQLController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }
        //[HttpGet]
        //public async Task<List<PopulationType>> GetPopulationGraphQl()
        //{
            
        //    _documentExecuter.ExecuteAsync(opt => {
        //        opt.Schema = _schema;

        //    );
               
        //}

    }
}
