
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ECardController {

    public ECardService ECardService;

    /// <summary>
    /// @param Resident 
    /// @return
    /// </summary>
    public Task GetECardService(Resident Resident) {
        // TODO implement here
        return null;
    }

    public ECardController(ECardService ECardService) {
        this.ECardService = ECardService;
    }

}