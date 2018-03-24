using Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IUnityOfWork:IDisposable
    {
        ICourseRepository Courses { get; }
        int Complete();
    }
}
