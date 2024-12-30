using System.Collections.Generic;

public class ECardController
{
    private ECardService eCardService;

    public ECardController(string filePath)
    {
        eCardService = new ECardService(filePath);
    }

    public void GetECardService(List<DataRow> dataRows, Dictionary<string, string[]> usersData)
    {
        eCardService.AddEcardToRepository(dataRows, usersData);
    }
}