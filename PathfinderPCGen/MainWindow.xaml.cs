using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using PathfinderPCGen.Classes;

namespace PathfinderPCGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            StatGenerator();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StatGenerator()
        {
            StandardRoll();
            //ClassicRoll();
        }

        private void ClassicRoll()
        {
            Dice dice = new Dice();
            StrLabel.Content = dice.ClassicRoll(6, 3);
            DexLabel.Content = dice.ClassicRoll(6, 3);
            ConLabel.Content = dice.ClassicRoll(6, 3);
            IntLabel.Content = dice.ClassicRoll(6, 3);
            WisLabel.Content = dice.ClassicRoll(6, 3);
            ChaLabel.Content = dice.ClassicRoll(6, 3);
        }

        private void StandardRoll()
        {
            Dice dice = new Dice();
            StrLabel.Content = dice.StandardRoll(6, 4, 1);
            DexLabel.Content = dice.StandardRoll(6, 4, 1);
            ConLabel.Content = dice.StandardRoll(6, 4, 1);
            IntLabel.Content = dice.StandardRoll(6, 4, 1);
            WisLabel.Content = dice.StandardRoll(6, 4, 1);
            ChaLabel.Content = dice.StandardRoll(6, 4, 1);
        }
    }
}
