using System.Collections.Generic;
using System.IO;

namespace WinFormsApp1
{
    public class ConditionService
    {
        private readonly ConditionList conditionList;

        public ConditionService()
        {
            conditionList = new ConditionList();
        }

        public void GetObjectFromRepository(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++) 
            {
                var columns = lines[i].Split(',');

                if (columns.Length == 5 && int.TryParse(columns[0], out int id))
                {
                    var condition = new Condition(id, columns[1], columns[2], columns[3], columns[4]);
                    conditionList.AddCondition(condition);
                }
                else
                {
                    throw new FormatException($"Ошибка в строке {i + 1}: неверный формат данных.");
                }
            }
        }

        public List<Condition> GetConditionFromRepository()
        {
            return conditionList.GetAllConditions();
        }

        public void AddConditionToRepository(Condition condition)
        {
            conditionList.AddCondition(condition);
            AddObjectToRepository("Condition.csv");
        }

        private void AddObjectToRepository(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Запись заголовка
                writer.WriteLine("ID,Reason,AllowedTime,Date,Status");

                foreach (var condition in conditionList.GetAllConditions())
                {
                    writer.WriteLine($"{condition.ID},{condition.Reason},{condition.AllowedTime},{condition.Date},{condition.Status}");
                }
            }
        }
        public void FreezeConditionInRepository(Condition condition)
        {
            conditionList.UpdateCondition(condition); 
            AddObjectToRepository("Condition.csv"); 
        }
    }
}