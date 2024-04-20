using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace StrategyPatternSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeStrategyMap();
        }
        private IStrategy _strategy = new SheepStrategyA(); //defaltのStratesyとして初期化
        private Dictionary<string, IStrategy> _strategyMap　= new Dictionary<string, IStrategy>();


        private void InitializeStrategyMap()
        {
            _strategyMap = new Dictionary<string, IStrategy>
            {
                { "radioButton1", new SheepStrategyA() },
                { "radioButton2", new SheepStrategyB() },
                { "radioButton3", new SheepStrategyC() }
            };
        }

        void DictionaryStratesy(object sender)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null) 
            if (_strategyMap.TryGetValue(radioButton.Name, out var strategy))
            {
                _strategy = strategy;
                ExecuteStrategy();
            }
        }


        public interface IStrategy
        {
            string Execute();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ifStratesy(sender);
        }


        void ifStratesy(object sender)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && _strategyMap.TryGetValue(radioButton.Name, out var strategy))
            {
                _strategy = strategy;
                ExecuteStrategy();
            }
        }


        void switchStratesy(object sender)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null)
                switch (radioButton.Name)
                {
                    case "radioButton1":
                        _strategy = new SheepStrategyA();
                        break;
                    case "radioButton2":
                        _strategy = new SheepStrategyB();
                        break;
                    case "radioButton3":
                        _strategy = new SheepStrategyC();
                        break;
                }

            ExecuteStrategy();


        }


        private void ExecuteStrategy()
        {
            if (_strategy != null)
            {
                textBlockResult.Text = _strategy.Execute();
            }
        }


        public class SheepStrategyA : IStrategy
        {
            public string Execute() => "選択されたオプションひつじは1です。";
        }

        public class SheepStrategyB : IStrategy
        {
            public string Execute() => "選択されたオプションひつじは2です。";
        }

        public class SheepStrategyC : IStrategy
        {
            public string Execute() => "選択されたオプションひつじは3です。";
        }
    }
}