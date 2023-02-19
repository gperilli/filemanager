using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST.Controllers;

[ApiController] // for REST API Controller
[Route("[controller]")]

public class UploadController : ControllerBase
    {
		[HttpPost(Name = "Upload")]
		public async Task<IActionResult> Index(IFormFile file, [FromQuery] string address)
		{            

			var filename = file.FileName;
			
			if (file.Length > 0)
			{
				var filePath = $"{address}/{filename}";
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await file.CopyToAsync(stream);
				}
			}
			
			// process uploaded files
			// Don't rely on or trust the FileName property without validation.
			return Ok(new { file });
		}
	}
	