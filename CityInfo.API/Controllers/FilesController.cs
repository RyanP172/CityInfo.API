using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw new System.ArgumentException(nameof(fileExtensionContentTypeProvider)); // ?? null coalescing operator
            //If whatever is to the left is not null, use that, otherwise use what's to the right."
        }
        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            // look up the actual file, depending on the fileId...
            // demo code
            var pathToFile = "creating-the-api-and-returning-resources-slides.pdf";

            // check if the file exists
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";//This is the default format of a content type
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile); // read all bytes and pass to the File method
            return File(bytes, contentType, Path.GetFileName(pathToFile));


        }
    }
}
