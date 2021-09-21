using Microsoft.AspNetCore.Mvc;
using PdfLambda.Model;
using WkHtmlToPdfDotNet;

namespace PdfLambda.Controllers
{
    [Route("api/[controller]")]
    public class PdfController : Controller
    {
        private readonly IPdfGeneratorHelper _generator; 
        public PdfController(IPdfGeneratorHelper generator)
        {
            _generator = generator;
        }
        [HttpGet("Generate")]
        public IActionResult GeneratePdf()
        {

            var pdf = _generator.Generate("<h1>Hello World</h1>", Orientation.Portrait);

            return Ok(new FilePDF(pdf, "application/pdf"));
        }
    }
}
