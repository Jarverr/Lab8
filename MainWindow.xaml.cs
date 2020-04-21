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

namespace Z8_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int allAnswersCount = 0;
        Dictionary<string, int> answers = new Dictionary<string, int>() {
            {
                "A",0
            },
            {
                "B",0
            },
            {
                "C",0
            },
            {
                "D",0
            }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_i(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var choice = button.Content.ToString();
            answers[choice]++;
            allAnswersCount++;
            AllAnswers.Text = allAnswersCount.ToString();
            RedrawGraph();
        } 

        private void RedrawGraph() 
        {
            var maxHeight = Canvas.ActualHeight;

            RA.Height = maxHeight * (answers["A"] / (double)allAnswersCount);
            RB.Height = maxHeight * (answers["B"] / (double)allAnswersCount);
            RC.Height = maxHeight * (answers["C"] / (double)allAnswersCount);
            RD.Height = maxHeight * (answers["D"] / (double)allAnswersCount);
            Stat2.Text = answers.Max(x => x.Value).ToString(); 
        }
    }
}
