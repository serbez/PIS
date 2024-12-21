
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConditionService {

    public ConditionRepository ConditionRepository;

    public ConditionService(ConditionRepository ConditionRepository) {
        this.ConditionRepository = ConditionRepository;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> GetConditionFromRepository() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> AddConditionToRepository() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public Task<Action> FreezeConditionInRepository(int id) {
        // TODO implement here
        return null;
    }

}