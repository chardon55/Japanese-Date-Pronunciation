using Japanese_Date_Pronunciation.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Japanese_Date_Pronunciation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateQuestion();
        }

        public enum States
        {
            READY,
            STARTED,
            SHOWING_ANSWER
        }

        private States state = States.READY;

        private DateQuestionGenerator generator = new DateQuestionGenerator();

        private DateQuestion question = null;

        private void GenerateQuestion()
        {
            question = generator.Generate();
        }

        private void Start()
        {
            GenerateQuestion();
            QuestionBlock.Text = $"{question.Month}{question.Day}";            
        }

        private void Reset()
        {
            // TODO
        }

        private void ShowAnswer()
        {
            QuestionBlock.Text += $"\n{question.TheAnswer.Month} {question.TheAnswer.Day}";
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            switch (state)
            {
                case States.READY:
                case States.SHOWING_ANSWER:
                    Start();
                    state = States.STARTED;
                    StartButton.Content = Names.ShowAnswer;
                    break;

                case States.STARTED:
                    ShowAnswer();
                    state = States.SHOWING_ANSWER;
                    StartButton.Content = Names.Next;
                    break;

                default:
                    break;
            }
        }

        private void QuestionBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
