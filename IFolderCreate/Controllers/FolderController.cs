using FolderDataModel;
using Microsoft.AspNetCore.Mvc;


namespace IFolderCreate.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult Index(FolderData folder)
        {
            System.IO.Directory.CreateDirectory(folder.dirPath + folder.dirName);
            return View(folder);
        }
    }
}
