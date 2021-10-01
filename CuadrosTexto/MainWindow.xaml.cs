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

namespace CuadrosTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void datos_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.Key == Key.F1)
            {
                switch (textBox.Tag)
                {
                    case "nombre":
                        ayudaNombreTextBlock.Text = "Nombre del cliente";
                        break;
                    case "apellido":
                        ayudaApellidoTextBlock.Text = "Apellido del cliente";
                        break;
                }
            }
        }

        private void edad_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.Key == Key.F2 && !int.TryParse(edadTextBox.Text, out i)) errorEdadTextBlock.Text = "Edad incorrecta";
        }
    }



}


