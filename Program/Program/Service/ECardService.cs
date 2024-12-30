using System.Collections.Generic;
using System.Data;
using System.IO;

public class ECardService
{
    private string filePath;

    public ECardService(string filePath)
    {
        this.filePath = filePath;
    }

    public void AddEcardToRepository(List<DataRow> dataRows, Dictionary<string, string[]> usersData)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Id,Phone,Имя,Фамилия,Отчество,Возраст,Национальность,Пол,Город,Адрес,Дата рождения");

            foreach (var row in dataRows)
            {
                var id = row.Id;
                var phone = row.Phone;

                if (usersData.TryGetValue(phone, out string[] userInfo))
                {
                    var line = $"{id},{phone},{userInfo[2]},{userInfo[3]},{userInfo[4]},{userInfo[5]},{userInfo[6]},{userInfo[7]},{userInfo[8]},{userInfo[10]},{userInfo[11]}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}