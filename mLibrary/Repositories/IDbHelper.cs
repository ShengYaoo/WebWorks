using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mLibrary.Repositories
{
    public interface IDbHelper<T> where T : class
    {
        List<T> Xml_Load();
        void InsertData(T item);
        List<T> QueryData(string searchColumn, string searchName);
        void UpdateData(int updateID, T item);
        void DeleteData(string deleteColumn, string deletehName);
        void ShowData(List<T> list);

    }
}
