using Microsoft.AspNetCore.Mvc;
using XML_API.Core.Entities;
using XML_API.Core.Interfaces;

namespace XML_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class xmlParserController : ControllerBase
    {
        private readonly IOntologyService _ontologyService;

        public xmlParserController(IOntologyService ontologyService)
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