
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConditionController {

    public ConditionService ConditionService;

    /// <summary>
    /// @param ConditionService
    /// </summary>
    public ConditionController(ConditionService ConditionService) {
        this.ConditionService = ConditionService;
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<List<Condition>> GetConditionsFromService() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> CreateCondition() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> EditCondition() {
        // TODO implement here
        return null;
    }

}