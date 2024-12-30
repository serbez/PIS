using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class ConditionController
    {
        private readonly ConditionService conditionService;

        public ConditionController()
        {
            conditionService = new ConditionService();
        }

        public void GetConditionsFromService(string filePath)
        {
            try
            {
                conditionService.GetObjectFromRepository(filePath);
                MessageBox.Show($"Загружено условий: {conditionService.GetConditionFromRepository().Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public List<Condition> GetAllConditions()
        {
            return conditionService.GetConditionFromRepository();
        }

        public void CreateCondition(Condition condition)
        {
            conditionService.AddConditionToRepository(condition);
        }
        public int GetNextConditionId()
        {
            var conditions = conditionService.GetConditionFromRepository();
            if (conditions.Count == 0)
            {
                return 5; 
            }
            return conditions.Max(c => c.ID) + 1;
        }
        public void EditCondition(Condition condition)
        {
            conditionService.FreezeConditionInRepository(condition);
        }
    }
}