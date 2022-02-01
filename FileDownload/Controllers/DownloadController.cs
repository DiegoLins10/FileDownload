using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileDownload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly string filePath;

        public DownloadController(string filePath)
        {
            this.filePath = filePath;
        }
        

        // GET: api/<DownloadController>
        [HttpGet]
        public FileContentResult Get()
        {
            return File(System.IO.File.ReadAllBytes(filePath), "application/octet-stream", "File.csv");
        }

      
    }
}
