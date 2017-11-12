using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lesson_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// Name: Krzysztof Szczurowski
    /// Week 3 Lab 1
    /// Repo address: https://github.com/kriss3/BCIT_WPF_COMP3608_Week3Lab1.git
    /// </summary>
    public partial class Binding : Window
    {
        public Binding()
        {
            InitializeComponent();
            foreach (FontFamily myFont in Fonts.SystemFontFamilies)
            {
                ListBoxItem l = new ListBoxItem
                {
                    Content = myFont.ToString(),
                    FontFamily = myFont
                };
                listBox1.Items.Add(l);
            }
        }
    }
}