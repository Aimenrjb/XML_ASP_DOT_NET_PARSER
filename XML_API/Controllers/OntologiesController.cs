using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XML_API.Core.Data;
using XML_API.Core.Entities;

namespace XML_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OntologiesFromDBController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OntologiesFromDBController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ontologies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ontology>>> GetOntologies()
        {
            return await    _context.Ontologies
                .ToListAsync();
        }
        [HttpGet("Declarations")]
        public async Task<ActionResult<IEnumerable<Declaration>>> GetDeclarations()
        {
            return await _context.Declarations.ToListAsync();
        }

        // GET: api/OntologyElements/SubClassOfs
        [HttpGet("SubClassOfs")]
        public async Task<ActionResult<IEnumerable<SubClassOf>>> GetSubClassOfs()
        {
            return await _context.SubClassOfs.ToListAsync();
        }

        // GET: api/OntologyElements/ClassAssertions
        [HttpGet("ClassAssertions")]
        public async Task<ActionResult<IEnumerable<ClassAssertion>>> GetClassAssertions()
        {
            return await _context.ClassAssertions.ToListAsync();
        }

        // GET: api/OntologyElements/SubObjectPropertyOfs
        [HttpGet("SubObjectPropertyOfs")]
        public async Task<ActionResult<IEnumerable<SubObjectPropertyOf>>> GetSubObjectPropertyOfs()
        {
            return await _context.SubObjectPropertyOfs.ToListAsync();
        }

        // GET: api/OntologyElements/InverseObjectProperties
        [HttpGet("InverseObjectProperties")]
        public async Task<ActionResult<IEnumerable<InverseObjectProperties>>> GetInverseObjectProperties()
        {
            return await _context.InverseObjectProperties.ToListAsync();
        }

        // GET: api/OntologyElements/ObjectPropertyDomains
        [HttpGet("ObjectPropertyDomains")]
        public async Task<ActionResult<IEnumerable<ObjectPropertyDomain>>> GetObjectPropertyDomains()
        {
            return await _context.ObjectPropertyDomains.ToListAsync();
        }

        // GET: api/OntologyElements/ObjectPropertyRanges
        [HttpGet("ObjectPropertyRanges")]
        public async Task<ActionResult<IEnumerable<ObjectPropertyRange>>> GetObjectPropertyRanges()
        {
            return await _context.ObjectPropertyRanges.ToListAsync();
        }

        // GET: api/OntologyElements/AnnotationAssertions
        [HttpGet("AnnotationAssertions")]
        public async Task<ActionResult<IEnumerable<AnnotationAssertion>>> GetAnnotationAssertions()
        {
            return await _context.AnnotationAssertions.ToListAsync();
        }


        // GET: api/Ontologies/5?include=Declarations
        [HttpGet("{id}")]
        public async Task<ActionResult<Ontology>> GetOntology(int id, string include = "")
        {
            IQueryable<Ontology> query = _context.Ontologies;

            switch (include.ToLower())
            {
                case "declarations":
                    query = query.Include(o => o.Declarations);
                    break;
                case "subclassofs":
                    query = query.Include(o => o.SubClassOfs);
                    break;
                case "classassertions":
                    query = query.Include(o => o.ClassAssertions);
                    break;
                case "subobjectpropertyofs":
                    query = query.Include(o => o.SubObjectPropertyOfs).ThenInclude(i => i.ObjectProperties); ;
                    break;
                case "inverseobjectproperties":
                    query = query.Include(o => o.InverseObjectProperties)
                        .ThenInclude(i=> i.ObjectProperties);
                    break;
                case "objectpropertydomains":
                    query = query.Include(o => o.ObjectPropertyDomains);
                    break;
                case "objectpropertyranges":
                    query = query.Include(o => o.ObjectPropertyRanges)
                                 .ThenInclude(opr => opr.ObjectProperty)
                                 .Include(o => o.ObjectPropertyRanges)
                                 .ThenInclude(opr => opr.Class);
                    break;
                case "annotationassertions":
                    query = query.Include(o => o.AnnotationAssertions);
                    break;
            }

            var ontology = await query.FirstOrDefaultAsync(o => o.Id == id);

            if (ontology == null)
            {
                return NotFound();
            }

            return ontology;
        }

        // PUT: api/Ontologies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOntology(int id, Ontology ontology)
        {
            if (id != ontology.Id)
            {
                return BadRequest();
            }

            _context.Entry(ontology).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OntologyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ontologies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ontology>> PostOntology(Ontology ontology)
        {
            _context.Ontologies.Add(ontology);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOntology", new { id = ontology.Id }, ontology);
        }

        // DELETE: api/Ontologies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOntology(int id)
        {
            var ontology = await _context.Ontologies.FindAsync(id);
            if (ontology == null)
            {
                return NotFound();
            }

            _context.Ontologies.Remove(ontology);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OntologyExists(int id)
        {
            return _context.Ontologies.Any(e => e.Id == id);
        }
    }
}
