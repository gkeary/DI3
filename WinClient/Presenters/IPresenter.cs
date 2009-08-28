using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WinClient.Presenters
{
    public interface IPresenter
    {
        DataTable GetData(string ID);
        bool SaveOrUpdate(DataTable entity);
    }
}
