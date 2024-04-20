using System.Windows.Controls;
using static ComplexStrategySample_sheephuman.ConditionContext;

namespace ComplexStrategySample_sheephuman
{
    public class ConditionBCDStrategy: IConditionBCDStrategy
    {
        private CheckBox checkBoxB;
        private CheckBox checkBoxC;
        private CheckBox checkBoxD;

        public ConditionBCDStrategy(CheckBox checkBoxB, CheckBox checkBoxC, CheckBox checkBoxD)
        {
            this.checkBoxB = checkBoxB;
            this.checkBoxC = checkBoxC;
            this.checkBoxD = checkBoxD;
        }

     

        public bool CheckConditionBCD()
        {
            return checkBoxB.IsChecked == true && checkBoxC.IsChecked == true && checkBoxD.IsChecked == true;
        }
    }

}
