using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interfaces
{
    public interface IPersonImageService
    {
        bool HandlePersonalImage(Person person, string newImagePath);
        bool HandelIdImage(Person person, string newIdImagePath); 
    }
}
