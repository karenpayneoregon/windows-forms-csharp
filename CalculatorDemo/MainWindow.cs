//using CalculatorDemo.Classes;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CalculatorDemo.Classes;

namespace CalculatorDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private static PaperTrail _paper;
        private Operation _lastOperator;
        private string _lastValue;
        private string _memValue;

        public MainWindow()
        {
            InitializeComponent();
            _paper = new PaperTrail(this);
            ProcessKey('0');
            EraseDisplay = true;
        }

        /// <summary>
        ///     Flag to erase or just add to current display flag
        /// </summary>
        private bool EraseDisplay { get; set; }

        /// <summary>
        ///     Get/Set Memory cell value
        /// </summary>
        private double Memory
        {
            get => _memValue == string.Empty ? 0.0 : Convert.ToDouble(_memValue);
            set => _memValue = value.ToString(CultureInfo.InvariantCulture);
        }

        //Lats value entered
        private string LastValue
        {
            get => _lastValue == string.Empty ? "0" : _lastValue;
            set => _lastValue = value;
        }

        //The current Calculator display
        private string Display { get; set; }
        // Sample event handler:  
        private void OnWindowKeyDown(object sender, TextCompositionEventArgs /*System.Windows.Input.KeyEventArgs*/ e)
        {
            var text = e.Text;
            var character = (text.ToCharArray())[0];
            e.Handled = true;

            if (character is >= '0' and <= '9' || character == '.' || character == '\b') // '\b' is backspace
            {
                ProcessKey(character);
                return;
            }
            switch (character)
            {
                case '+':
                    ProcessOperation("BPlus");
                    break;
                case '-':
                    ProcessOperation("BMinus");
                    break;
                case '*':
                    ProcessOperation("BMultiply");
                    break;
                case '/':
                    ProcessOperation("BDevide");
                    break;
                case '%':
                    ProcessOperation("BPercent");
                    break;
                case '=':
                    ProcessOperation("BEqual");
                    break;
            }
        }

        private void DigitBtn_Click(object sender, RoutedEventArgs e)
        {
            var text = ((Button) sender).Content.ToString();

            //char[] ids = ((Button)sender).ID.ToCharArray();
            var ids = text.ToCharArray();
            ProcessKey(ids[0]);
        }

        private void ProcessKey(char c)
        {
            if (EraseDisplay)
            {
                Display = string.Empty;
                EraseDisplay = false;
            }
            AddToDisplay(c);
        }

        private void ProcessOperation(string s)
        {
            var doubleValue = 0.0;
            switch (s)
            {
                case "BPM":
                    _lastOperator = Operation.Negate;
                    LastValue = Display;
                    CalcResults();
                    LastValue = Display;
                    EraseDisplay = true;
                    _lastOperator = Operation.None;
                    break;
                case "BDevide":

                    if (EraseDisplay) //still wait for a digit...
                    {
                        //still wait for a digit...
                        _lastOperator = Operation.Devide;
                        break;
                    }
                    CalcResults();
                    _lastOperator = Operation.Devide;
                    LastValue = Display;
                    EraseDisplay = true;
                    break;
                case "BMultiply":
                    if (EraseDisplay) //still wait for a digit...
                    {
                        //still wait for a digit...
                        _lastOperator = Operation.Multiply;
                        break;
                    }
                    CalcResults();
                    _lastOperator = Operation.Multiply;
                    LastValue = Display;
                    EraseDisplay = true;
                    break;
                case "BMinus":
                    if (EraseDisplay) //still wait for a digit...
                    {
                        //still wait for a digit...
                        _lastOperator = Operation.Subtract;
                        break;
                    }
                    CalcResults();
                    _lastOperator = Operation.Subtract;
                    LastValue = Display;
                    EraseDisplay = true;
                    break;
                case "BPlus":
                    if (EraseDisplay)
                    {
                        //still wait for a digit...
                        _lastOperator = Operation.Add;
                        break;
                    }
                    CalcResults();
                    _lastOperator = Operation.Add;
                    LastValue = Display;
                    EraseDisplay = true;
                    break;
                case "BEqual":
                    if (EraseDisplay) //still wait for a digit...
                        break;
                    CalcResults();
                    EraseDisplay = true;
                    _lastOperator = Operation.None;
                    LastValue = Display;
                    //val = Display;
                    break;
                case "BSqrt":
                    _lastOperator = Operation.Sqrt;
                    LastValue = Display;
                    CalcResults();
                    LastValue = Display;
                    EraseDisplay = true;
                    _lastOperator = Operation.None;
                    break;
                case "BPercent":
                    if (EraseDisplay) //still wait for a digit...
                    {
                        //still wait for a digit...
                        _lastOperator = Operation.Percent;
                        break;
                    }
                    CalcResults();
                    _lastOperator = Operation.Percent;
                    LastValue = Display;
                    EraseDisplay = true;
                    //LastOper = Operation.None;
                    break;
                case "BOneOver":
                    _lastOperator = Operation.OneX;
                    LastValue = Display;
                    CalcResults();
                    LastValue = Display;
                    EraseDisplay = true;
                    _lastOperator = Operation.None;
                    break;
                case "BC": //clear All
                    _lastOperator = Operation.None;
                    Display = LastValue = string.Empty;
                    _paper.Clear();
                    UpdateDisplay();
                    break;
                case "BCE": //clear entry
                    _lastOperator = Operation.None;
                    Display = LastValue;
                    UpdateDisplay();
                    break;
                case "BMemClear":
                    Memory = 0.0F;
                    DisplayMemory();
                    break;
                case "BMemSave":
                    Memory = Convert.ToDouble(Display);
                    DisplayMemory();
                    EraseDisplay = true;
                    break;
                case "BMemRecall":
                    Display = /*val =*/ Memory.ToString(CultureInfo.InvariantCulture);
                    UpdateDisplay();
                    //if (LastOper != Operation.None)   //using MR is like entering a digit
                    EraseDisplay = false;
                    break;
                case "BMemPlus":
                    doubleValue = Memory + Convert.ToDouble(Display);
                    Memory = doubleValue;
                    DisplayMemory();
                    EraseDisplay = true;
                    break;
            }
        }

        private void OperBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessOperation(((Button) sender).Name);
        }

        private double Calc(Operation lastOperator)
        {
            var doubleValue = 0.0;


            try
            {
                switch (lastOperator)
                {
                    case Operation.Devide:
                        _paper.AddArguments(LastValue + " / " + Display);
                        doubleValue = (Convert.ToDouble(LastValue)/Convert.ToDouble(Display));
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Add:
                        _paper.AddArguments(LastValue + " + " + Display);
                        doubleValue = Convert.ToDouble(LastValue) + Convert.ToDouble(Display);
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Multiply:
                        _paper.AddArguments(LastValue + " * " + Display);
                        doubleValue = Convert.ToDouble(LastValue)*Convert.ToDouble(Display);
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Percent:
                        //Note: this is different (but make more sense) then Windows calculator
                        _paper.AddArguments(LastValue + " % " + Display);
                        doubleValue = (Convert.ToDouble(LastValue)*Convert.ToDouble(Display))/100.0F;
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Subtract:
                        _paper.AddArguments(LastValue + " - " + Display);
                        doubleValue = Convert.ToDouble(LastValue) - Convert.ToDouble(Display);
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Sqrt:
                        _paper.AddArguments("Sqrt( " + LastValue + " )");
                        doubleValue = Math.Sqrt(Convert.ToDouble(LastValue));
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.OneX:
                        _paper.AddArguments("1 / " + LastValue);
                        doubleValue = 1.0F/Convert.ToDouble(LastValue);
                        CheckResult(doubleValue);
                        _paper.AddResult(doubleValue.ToString(CultureInfo.InvariantCulture));
                        break;
                    case Operation.Negate:
                        doubleValue = Convert.ToDouble(LastValue)*(-1.0F);
                        break;
                }
            }
            catch
            {
                doubleValue = 0;
                var parent = (Window) MyPanel.Parent;
                _paper.AddResult("Error");
                MessageBox.Show(parent, "Operation cannot be performed", parent.Title);
            }

            return doubleValue;
        }

        private void CheckResult(double d)
        {
            if (double.IsNegativeInfinity(d) || double.IsPositiveInfinity(d) || double.IsNaN(d))
                throw new Exception("Illegal value");
        }

        private void DisplayMemory()
        {
            if (_memValue != string.Empty)
            {
                BMemBox.Text = "Memory: " + _memValue;
            }
            else
            {
                BMemBox.Text = "Memory: [empty]";
            }
        }

        private void CalcResults()
        {
            double value;
            if (_lastOperator == Operation.None)
            {
                return;
            }

            value = Calc(_lastOperator);
            Display = value.ToString(CultureInfo.InvariantCulture);

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            DisplayBox.Text = Display == string.Empty ? "0" : Display;
        }

        private void AddToDisplay(char character)
        {
            if (character == '.')
            {
                if (Display.IndexOf('.', 0) >= 0) //already exists
                    return;
                Display = Display + character;
            }
            else
            {
                if (character >= '0' && character <= '9')
                {
                    Display = Display + character;
                }
                else if (character == '\b') //backspace ?
                {
                    if (Display.Length <= 1)
                        Display = string.Empty;
                    else
                    {
                        var i = Display.Length;
                        Display = Display.Remove(i - 1, 1); //remove last char 
                    }
                }
            }

            UpdateDisplay();
        }

        private void OnMenuAbout(object sender, RoutedEventArgs e)
        {
            Dialogs.InformationDialog($"Created by Jossef Goldberg\nModified by Karen Payne", ((Window)MyPanel.Parent).Title);
        }

        private void OnMenuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnMenuStandard(object sender, RoutedEventArgs e)
        {
            //((MenuItem)ScientificMenu).IsChecked = false;
            StandardMenu.IsChecked = true; //for now always Standard
        }

        private void OnMenuScientific(object sender, RoutedEventArgs e)
        {
            //((MenuItem)StandardMenu).IsChecked = false; 
        }

        private enum Operation
        {
            None,
            Devide,
            Multiply,
            Subtract,
            Add,
            Percent,
            Sqrt,
            OneX,
            Negate
        }

        private class PaperTrail
        {
            private readonly MainWindow _window;
            private string _args;

            public PaperTrail(MainWindow window)
            {
                _window = window;
            }

            public void AddArguments(string sender)
            {
                _args = sender;
            }

            public void AddResult(string r)
            {
                _window.PaperBox.Text += _args + " = " + r + "\n";
            }

            public void Clear()
            {
                _window.PaperBox.Text = string.Empty;
                _args = string.Empty;
            }
        }
    }
}