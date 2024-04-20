using System.Windows.Controls;
using static ComplexStrategySample_sheephuman.ConditionContext;


namespace ComplexStrategySample_sheephuman
{



    public class ConditionABStrategy : IConditionABStrategy
    {



        private CheckBox checkBoxA;
        private CheckBox checkBoxB;

        public ConditionABStrategy(CheckBox checkBoxA, CheckBox checkBoxB)
        {
            this.checkBoxA = checkBoxA;
            this.checkBoxB = checkBoxB;
        }

        public bool CheckConditionAB()
        {
            return checkBoxA.IsChecked == true && checkBoxB.IsChecked == true;
        }

    }

}
