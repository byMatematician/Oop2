using System.Collections.Generic;

namespace Oop3Interface
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager)
        {
            creditManager.Calculate();

        }
        public void CreditEvaluation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
    
       
    
}
