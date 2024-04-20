namespace ComplexStrategySample_sheephuman
{
    public class ConditionContext
    {
        private IConditionABStrategy? abstrategy ;
        private IConditionBCDStrategy? bcdstrategy;

        public ConditionContext(IConditionABStrategy strategy)
        {
            
            this.abstrategy = strategy;
        }

        public ConditionContext(IConditionBCDStrategy strategy)
        {
            this.bcdstrategy = strategy;
        }

        public interface IConditionABStrategy
        {
            bool CheckConditionAB();

        }
        public interface IConditionBCDStrategy
        {
            bool CheckConditionBCD();

        }

        public bool EvaluateBCD()
        {
            if (bcdstrategy != null)                 
                return bcdstrategy.CheckConditionBCD();
            return false;
        }

        public bool EvaluateAB()
        {
            if (abstrategy != null)
                return abstrategy.CheckConditionAB();
            return false;
        }
    }

}
