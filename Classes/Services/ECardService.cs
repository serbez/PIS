
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ECardService {

    public ECardRepository ECardRepository;

    /// <summary>
    /// @param ECardRepository 
    /// @param Resident 
    /// @return
    /// </summary>
    public Task<List<ECard>> GetECardFromRepository(ECardRepository ECardRepository, Resident Resident) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param ECard 
    /// @return
    /// </summary>
    public Task<Action> AddEcardToRepository(ECard eCard) {
        // TODO implement here
        return null;
    }

    public void Operation1() {
        // TODO implement here
    }

    /// <summary>
    /// @param ECardRepository
    /// </summary>
    public ECardService(ECardRepository ECardRepository) {
        this.ECardRepository = ECardRepository;

        // TODO implement here
    }

}