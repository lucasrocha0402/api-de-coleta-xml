using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class DocumentsController : controllerBase
{
    private readonly AppDbContext _context;

    public DocumentsController (AppDbContext context)
    {
        _context = context;
    }

    [HttGet("{id}")]
    public async Task<IActionResult> GetDocument(int id)
    {
        var document = await _context.GetDocument(0id);
        if(document == null)
        {
            return NotFound(); 
        }
        return Ok(document.XmlData)
    }
}