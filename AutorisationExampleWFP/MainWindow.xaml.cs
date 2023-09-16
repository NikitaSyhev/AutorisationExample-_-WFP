using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutorisationExampleWFP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Элемент, который позволяет размещать
            // элемент управления Windows Forms
            // на странице WPF.
            WindowsFormsHost host = new WindowsFormsHost();

            // Создаём свой maskedTextBoxPassword
            MaskedTextBox maskedTextBoxPassword = new MaskedTextBox();
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new System.Drawing.Size(253, 38);
            maskedTextBoxPassword.Font = 
                new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 
                20F, 
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(204)));
            maskedTextBoxPassword.BackColor = System.Drawing.Color.GhostWhite;

            // Выбираем родительский элемент.
            host.Child = maskedTextBoxPassword;
            
            
            // Добавляем созданный нами host в Grid
            this.myGrid.Children.Add(host);
            Grid.SetColumn(host, 2);
            Grid.SetRow(host, 1);
        }
    }
}
