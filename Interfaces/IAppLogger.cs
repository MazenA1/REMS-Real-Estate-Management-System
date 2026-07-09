using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAppLogger
    {
        void LogInfo(string Message);
        void LogWarning(string Message);
        void LogError(string Message, Exception ex = null);

    }
}
