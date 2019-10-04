using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.Models;

namespace TMS.Interface
{
    interface ITraineeServices
    {
        void Create(Trainee trainee);
        Trainee Read(int id);
        Dictionary<int,Trainee> Read();
        void Update(int id, Trainee trainee);
        void Delete(int id);
    }
}
