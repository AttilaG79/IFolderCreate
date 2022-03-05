using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderDataModel
{
    public class FolderData
    {
        public string? dirName { get; set; }
        public string dirPath { get; set; }

        public FolderData()
        {
            this.dirPath = @"C:\";
        }

    }
}
