using System.Windows;
using System.Windows.Controls;
using static ComplexStrategySample_sheephuman.ConditionContext;

namespace ComplexStrategySample_sheephuman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     
        public bool CheckCondition()
        {
            return CheckBoxA.IsChecked == true && CheckBoxB.IsChecked == true;
        }

        private void EvaluateButton_Click(object sender, RoutedEventArgs e)
        {
            EveluteAB();


        }
        void EveluteBCD()
        {
            // 条件BCDの戦略を選択
          IConditionBCDStrategy strategy = new ConditionBCDStrategy(CheckBoxB, CheckBoxC,CheckBoxD);
            ConditionContext context = new ConditionContext(strategy);
            if (context.EvaluateBCD())
            {
                MessageBox.Show("条件B,C,Dがチェックされました。");
            }
            else
            {
                MessageBox.Show("B,C,Dのいずれかがチェックされていません。");
            }


        }

        void EveluteAB()
        {

            // 条件ABの戦略を選択
            IConditionABStrategy strategyAB = new ConditionABStrategy(CheckBoxA, CheckBoxB);
            ConditionContext context = new ConditionContext(strategyAB);

            if (context.EvaluateAB())
            {
                MessageBox.Show("条件Aと条件Bがチェックされました。");
            }
            else
            {
                EveluteBCD();
            }
        }
    }
}