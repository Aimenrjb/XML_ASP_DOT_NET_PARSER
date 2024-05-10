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
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            try
            {

                // Pass the file stream to the service
                var result = await _ontologyService.ProcessOntologyFile(file.OpenReadStream());

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error processing the file: {ex.Message}");
            }
        }
    }
}