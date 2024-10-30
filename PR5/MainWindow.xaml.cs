using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TriardClass;

namespace PR5
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

        private void btCalculater_Click(object sender, RoutedEventArgs e)
        {
            Triard triard = new Triard();
            bool boolOnePositiveNumber = int.TryParse(tbOnePositiveNumber.Text, out int oneNumber);
            bool boolTwoPositiveNumber = int.TryParse(tbTwoPositiveNumber.Text, out int twoNumber);
            bool boolThreePositiveNumber = int.TryParse(tbThreePositiveNumber.Text, out int threeNumber);
            if(boolOnePositiveNumber == true || boolTwoPositiveNumber == true || boolThreePositiveNumber == true)
            {
                int onePositiveNumber = Convert.ToInt32(oneNumber);
                int twoPositiveNumber = Convert.ToInt32(twoNumber);
                int threePositivenumber = Convert.ToInt32(threeNumber);
                triard.SetParams(onePositiveNumber,twoPositiveNumber,threePositivenumber);
                int Sum = triard.SumNumber();
                tbCalculater.Text = Convert.ToString(Sum);
            }
            else MessageBox.Show("Введите числа!!!");
        }
        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сделал:Ермаков Павел\nГруппа:ИСП-34\nЗадание:Создать класс Triad (тройка положительных чисел). Создать необходимые методы и свойства." +
                " Определить метод вычисления суммы чисел. Создать перегруженные методы SetParams, для установки параметров объекта.");
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}