using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace Sklad
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}