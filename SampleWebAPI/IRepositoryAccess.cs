using System;
using System.Collections.Generic;
using System.Text;

namespace SampleWebAPI
{
    public interface IRepositoryAccess
    {
        string PostOrder(Order orderobj);
    }
}
