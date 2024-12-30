using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class ConditionList
    {
        private readonly List<Condition> conditions;

        public ConditionList()
        {
            conditions = new List<Condition>();
        }

        public void AddCondition(Condition condition)
        {
            conditions.Add(condition);
        }

        public List<Condition> GetAllConditions()
        {
            return conditions;
        }

        public void UpdateCondition(Condition condition)
        {
            var existingCondition = conditions.FirstOrDefault(c => c.ID == condition.ID);
            if (existingCondition != null)
            {
                existingCondition.Reason = condition.Reason;
                existingCondition.AllowedTime = condition.AllowedTime;
                existingCondition.Date = condition.Date;
                existingCondition.Status = condition.Status;
            }
        }

    }
}
