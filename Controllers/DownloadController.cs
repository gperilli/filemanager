using Microsoft.AspNetCore.Mvc;

namespace REST.Controllers;

[ApiController] // for REST API Controller
[Route("[controller]")]

public class DownloadController : ControllerBase
{
    [HttpGet(Name = "GetDownload")]
    public IActionResult GetBlobDownload([FromQuery] string link)
    {
        var net = new System.Net.WebClient();
        var data = net.DownloadData(link);
        var content = new System.IO.MemoryStream(data);
        var contentType = "APPLICATION/octet-stream";
        var fileName = link.Substring(link.LastIndexOf('/') + 1);;
        return File(content, contentType, fileName);
    }
}
