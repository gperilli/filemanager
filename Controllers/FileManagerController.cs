using Microsoft.AspNetCore.Mvc;

namespace REST.Controllers;

[ApiController] // for REST API Controller
[Route("[controller]")]
public class FileManagerController : ControllerBase
{
    private readonly ILogger<FileManagerController> _logger;

    public FileManagerController(ILogger<FileManagerController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFileManager")]
    public IEnumerable<string> Get([FromQuery] string address)
    {
        List<String> files = new List<String>();
        try
        {
            foreach (string d in Directory.GetDirectories(address))
            {
                files.Add($"//{d}");
            }
            foreach (string f in Directory.GetFiles(address))
            {
                long length = new System.IO.FileInfo(f).Length;
                files.Add($"{f}, {length.ToString()}");
            }
            
        }
        catch (System.Exception excpt)
        {
            //MessageBox.Show(excpt.Message);
        }

        return files;
        
    }
}
