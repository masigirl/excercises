using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Workflow:IWorkflow
    {
        private readonly IList<IActivity> _activities; 
        public Workflow(IList<IActivity> activities)
        {
            _activities = activities;
        }
        
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
