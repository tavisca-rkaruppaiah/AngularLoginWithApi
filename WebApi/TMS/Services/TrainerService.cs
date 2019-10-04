using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.Interface;
using TMS.Models;

namespace TMS.Services
{
    public class TrainerService : ITrainerServices
    {
        private static Dictionary<int, Trainer> trainers = new Dictionary<int, Trainer>();
        public void Create(Trainer trainer)
        {
            trainers.Add(trainer.employee.id, trainer);
        }

        public void Delete(int id)
        {
            if(trainers.ContainsKey(id))
            {
                trainers.Remove(id);
            }
        }

        public Trainer Read(int id)
        {
            if(trainers.ContainsKey(id))
            {
                return trainers[id];
            }
            return null;
        }

        public Dictionary<int, Trainer> Read()
        {
            return trainers;
        }

        public void Update(int id, Trainer trainer)
        {
            if(trainers.ContainsKey(id))
            {
                trainers[id] = trainer;
            }
        }
    }
}
