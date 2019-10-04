using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.Models;

namespace TMS.Interface
{
    interface ITrainerServices
    {
        void Create(Trainer trainer);
        Trainer Read(int id);
        Dictionary<int,Trainer> Read();
        void Update(int id, Trainer trainer);
        void Delete(int id);
    }
}
