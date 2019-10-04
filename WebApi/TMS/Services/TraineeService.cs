using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.Interface;
using TMS.Models;

namespace TMS.Services
{
    public class TraineeService : ITraineeServices
    {
        private static Dictionary<int, Trainee> trainees = new Dictionary<int, Trainee>();
        public void Create(Trainee trainee)
        {
            trainees.Add(trainee.employee.id, trainee);
        }

        public void Delete(int id)
        {
            if(trainees.ContainsKey(id))
            {
                trainees.Remove(id);
            }
        }

        public Trainee Read(int id)
        {
            if(trainees.ContainsKey(id))
            {
                return trainees[id];
            }
            return null;
        }

        public Dictionary<int, Trainee> Read()
        {
            return trainees;
        }

        public void Update(int id, Trainee trainee)
        {
            if(trainees.ContainsKey(id))
            {
                trainees[id] = trainee;
            }
        }
    }
}
