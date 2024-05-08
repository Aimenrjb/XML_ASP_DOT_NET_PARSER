using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using XML_API.Core.Entities;

namespace XML_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class xmlParserController : ControllerBase
    {
        private readonly Infrastructure.Persistence.OntologyService _ontologyService;

        public xmlParserController(Infrastructure.Persistence.OntologyService ontologyService)
        {
            _ontologyService = ontologyService;
        }

        [HttpGet]
        public ActionResult<Ontology> Get()
        {
            try
            {
                var ontology = _ontologyService.GetOntology();
                return Ok(ontology);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error reading or deserializing the ontology: {ex.Message}");
            }
        }
    }
}