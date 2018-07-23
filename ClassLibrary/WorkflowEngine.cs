using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WorkflowEngine
    {
        public bool Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                if (!activity.Excecute())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
