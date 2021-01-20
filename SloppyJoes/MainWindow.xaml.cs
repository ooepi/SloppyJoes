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

namespace SloppyJoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            for (int i = 0; i < 5; i++)
            {
                if (i<3)
                {
                    menuItems[i] = new MenuItem();
                }
                else
                {
                    menuItems[i] = new MenuItem()
                    {
                        Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" }
                    };
                }
            }

            SandwichOne.Text = menuItems[0].GenerateMenuItem();
            PriceOne.Text = menuItems[0].RandomPrice();
            SandwichTwo.Text = menuItems[0].GenerateMenuItem();
            PriceTwo.Text = menuItems[0].RandomPrice();
            SandwichThree.Text = menuItems[0].GenerateMenuItem();
            PriceThree.Text = menuItems[0].RandomPrice();
            SandwichFour.Text = menuItems[0].GenerateMenuItem();
            PriceFour.Text = menuItems[0].RandomPrice();
            SandwichFive.Text = menuItems[0].GenerateMenuItem();
            PriceFive.Text = menuItems[0].RandomPrice();

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            SandwichSix.Text = specialMenuItem.GenerateMenuItem();
            PriceSix.Text = specialMenuItem.RandomPrice();

            guacamole.Text = "Add guacamole for " + specialMenuItem.RandomPrice();
        }
    }
}
