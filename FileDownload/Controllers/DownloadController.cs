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
            var data = System.IO.File.ReadAllBytes(filePath);
            var result = new FileContentResult(data, "application/octet-stream");
            {
                result.FileDownloadName = "File.csv";
            };
            return result;
        }

      
    }
}
