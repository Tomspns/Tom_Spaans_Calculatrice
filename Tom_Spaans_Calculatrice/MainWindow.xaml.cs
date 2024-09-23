using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Tom_Spaans_Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Initialisation des composants de l'interface utilisateur
        }

        int first_nb; // Premier nombre à saisir pour le calcul
        int second_nb; // Deuxième nombre à saisir pour le calcul
        int result; // Résultat du calcul
        char operation; // Opération à effectuer

        // Fonctions pour les boutons chiffres
        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        // Fonctions pour les boutons d'opérations
        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text); // Stock le premier nombre
            TB_Display.Text = "0"; // Réinitialise l'affichage pour saisir l'opération
            operation = '+'; // Définit l'opération
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_Diviser_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Clear(); // Efface la totalité de l'écran
        }

        // Fonctions pour les boutons Racine, COS, SIN et TAN
        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '√';
        }

        private void BTN_COS_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'C';
        }

        private void BTN_SIN_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'S';
        }

        private void BTN_TAN_Click(object sender, RoutedEventArgs e)
        {
            first_nb = int.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = 'T';
        }

        // Fonction pour le bouton "=" to do all the operations 
        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {
            second_nb = Int32.Parse(TB_Display.Text); // Stock le deuxième nombre
            switch (operation)
            {
                case '+':
                    result = first_nb + second_nb;
                    TB_Display.Text = result.ToString();
                    break;

                case '-':
                    result = first_nb - second_nb;
                    TB_Display.Text = result.ToString();
                    break;

                case '*':
                    result = first_nb * second_nb;
                    TB_Display.Text = result.ToString();
                    break;

                case '/':
                    result = first_nb / second_nb;
                    TB_Display.Text = result.ToString();
                    break;

                case '√':
                    double racineCarree = Math.Sqrt(first_nb);
                    TB_Display.Text = racineCarree.ToString();
                    break;

                case 'C':
                    double angle = Convert.ToDouble(first_nb); // Convertit la variable en un nombre à virgule
                    double angleEnRadians = angle * (Math.PI / 180); // L'angle en radians est convertit en degrés
                    double cosinus = Math.Cos(angleEnRadians); // Calcule le cosinus de l’angle en utilisant la fonction Math
                    TB_Display.Text = cosinus.ToString(); // Convertit la valeur en chaîne de caractères pour l’afficher
                    break;

                case 'S':
                    double angle2 = Convert.ToDouble(first_nb);
                    double angleEnRadians2 = angle2 * (Math.PI / 180);
                    double sinus = Math.Sin(angleEnRadians2);
                    TB_Display.Text = sinus.ToString();
                    break;

                case 'T':
                    double angle3 = Convert.ToDouble(first_nb);
                    double angleEnRadians3 = angle3 * (Math.PI / 180);
                    double tangente = Math.Tan(angleEnRadians3);
                    TB_Display.Text = tangente.ToString();
                    break;
            }
        }

        // Fonction pour afficher les chiffres dans le TextBox
        public void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }
    }
}

