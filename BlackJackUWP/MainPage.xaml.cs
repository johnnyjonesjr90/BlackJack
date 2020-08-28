using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BlackJackLibrary;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BlackJackUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        int Playercard1;
        int Playercard2;
        int Playercard3;
        int Dealercard1;
        int Dealercard2;
        int Dealercard3;
        int card = 3;
        int Dcard = 3;
        int total;
        int Dtotal;
        Cards cards = new Cards();
        Logic logic = new Logic();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dcard = 3;
            PlayerCards.Text = "";
            DealerCards.Text = "";
            DealerTotal.Text = "";
            PlayerTotal.Text = "";
            Results.Text = "";
            Dealercard1 = logic.Convert(cards.ShuffleAndDeal(), 0);
            Dealercard2 = logic.Convert(cards.ShuffleAndDeal(), 0);
            Playercard1 = logic.Convert(cards.ShuffleAndDeal(), 0);
            Playercard2 = logic.Convert(cards.ShuffleAndDeal(), 0);
            Dtotal = Dealercard1 + Dealercard2;
            total = Playercard1 + Playercard2;
            if (total > 21)
            {
                total = 2;
            }
            PlayerCards.Text = $"{cards.Suitchoice()} {Playercard1}";
            PlayerCards2.Text = $"{cards.Suitchoice()} {Playercard2}";
            DealerCards.Text = $"{cards.Suitchoice()} {Dealercard1}";
            DealerCards2.Text = $"{cards.Suitchoice()} {Dealercard2}";
            DealerTotal.Text = $"{Dtotal}";
            PlayerTotal.Text = $"{total}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (card == 3)
            {
                Playercard3 = logic.Convert(cards.ShuffleAndDeal(), total);
                total += Playercard3;
                PlayerCards3.Text = $"{cards.Suitchoice()} {Playercard3}";
                PlayerTotal.Text = $"{total}";
                if (total > 21)
                {
                    PlayerCards.Text = $" {logic.Bust()}";


                }
                if (total == 21)
                {

                    PlayerCards.Text = $" {logic.Hit21()}";

                }
                
            }
            if (card == 4)
            {
                Playercard3 = logic.Convert(cards.ShuffleAndDeal(), total);
                total += Playercard3;
                PlayerCards4.Text = $"{cards.Suitchoice()} {Playercard3}";
                PlayerTotal.Text = $"{total}";
                if (total > 21)
                {
                    PlayerCards.Text = $" {logic.Bust()}";


                }
                if (total == 21)
                {

                    PlayerCards.Text = $" {logic.Hit21()}";

                }
                
            }
            if (card == 5)
            {
                Playercard3 = logic.Convert(cards.ShuffleAndDeal(), total);
                total += Playercard3;
                PlayerCards5.Text = $"{cards.Suitchoice()} {Playercard3}";
                PlayerTotal.Text = $"{total}";
                if (total > 21)
                {
                    Results.Text = $" {logic.Bust()}";


                }
                if (total == 21)
                {

                    Results.Text = $" {logic.Hit21()}";

                }
            }
            card++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Dtotal);
            int exit3 = 0;
            while (exit3 == 0)
            {
                if (Dtotal <= 16&&Dcard==3)
                {
                    Dealercard3 = logic.Convert(cards.ShuffleAndDeal(), 0);
                    Dtotal += Dealercard3;
                    DealerCards3.Text = $"{cards.Suitchoice()} {Dealercard3}";
                    DealerTotal.Text = $" {Dtotal}";
                    
                }
                if (Dtotal < 16 && Dcard == 4)
                {
                    Dealercard3 = logic.Convert(cards.ShuffleAndDeal(), 0);
                    Dtotal += Dealercard3;
                    DealerCards4.Text = $"{cards.Suitchoice()} {Dealercard3}";
                    DealerTotal.Text = $" {Dtotal}";
                    
                }
                if (Dtotal < 16 && Dcard == 5)
                {
                    Dealercard3 = logic.Convert(cards.ShuffleAndDeal(), 0);
                    Dtotal += Dealercard3;
                    DealerCards5.Text = $"{cards.Suitchoice()} {Dealercard3}";
                    DealerTotal.Text = $" {Dtotal}";

                }
                if (Dtotal >= 16)
                {
                    DealerCards.Text = $"{Dtotal}";
                    if (total > Dtotal && total < 22)
                    {

                        Results.Text = "Congrats!!! you win";
                        
                        exit3 = 1;

                    }
                    if (Dtotal > total && Dtotal < 22)
                    {

                        Results.Text = "Dealer wins";
                        
                        exit3 = 1;
                    }
                    if (Dtotal > 21)
                    {
                        DealerTotal.Text = $" {Dtotal}";
                        Results.Text = "Congrats!!! you win";
                        
                        exit3 = 1;
                    }


                }
                card = 3;
                Dcard++;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DealerCards_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DealerTotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
