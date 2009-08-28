using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BLL.Interface
{
    public interface IBLL
    {
        DataTable GetAll();
        DataTable GetById(string ID);
        bool SaveOrUpdate(DataTable entity);
    }
}
