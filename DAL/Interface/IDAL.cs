using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL.Interface
{
    public interface IDAL
    {
       DataTable GetAll();
       DataTable GetById(string ID);
       bool SaveOrUpdate(DataTable entity);
    }
}
