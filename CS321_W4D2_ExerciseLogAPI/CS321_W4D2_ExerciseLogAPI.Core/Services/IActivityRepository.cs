using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityRepository
    {
        
        Activity Add(Activity activity);
        
        Activity Get(int id);
        
        Activity Update(Activity activity);
        
        void Remove(Activity activity);
        
        IEnumerable<Activity> GetAll();
    }
}