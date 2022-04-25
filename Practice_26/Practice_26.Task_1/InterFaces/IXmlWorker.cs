using Practice_26.Task_1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_26.Task_1.InterFaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Parking parking);
        void Delete(string mark);
        Parking FindBy(string mark);
        List<Parking> GetAll();
    }
}
