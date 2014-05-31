using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PrzewozniczekWedrowniczek.Resources;
using PrzewozniczekWedrowniczek._controller;
using PrzewozniczekWedrowniczek._model;

namespace PrzewozniczekWedrowniczek
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DrinkModel drinkModel;
        private ParametersModel parameters;

        public MainPage()
        {
            InitializeComponent();
            drinkModel = new DrinkModel();
            parameters = new ParametersModel();

            BeerCount.DataContext = drinkModel;
            WineCount.DataContext = drinkModel;
            VodkaCount.DataContext = drinkModel;

            DrinkingTime.DataContext = parameters;
            WaitingTime.DataContext = parameters;
            TravellingTime.DataContext = parameters;
            ManWeight.DataContext = parameters;
            WalkingTime.DataContext = parameters;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Equals(ManRadio))
            {
                parameters.Sex = radio.IsChecked.Value ? Sex.MAN : Sex.WOMAN;
            }
            else if (radio.Equals(WomanRadio))
            {
                parameters.Sex = radio.IsChecked.Value ? Sex.WOMAN : Sex.MAN;
            }
        }

        private void ToDrinksPanel_Click(object sender, RoutedEventArgs e)
        {
            PivotPanel.SelectedIndex = 1;
            System.Diagnostics.Debug.WriteLine(parameters.Sex.ToString() + " "
                + parameters.DrinkingTime.ToString() + " "
                + parameters.RidingTime.ToString() + " "
                + parameters.WaitingTime.ToString() + " " 
                + parameters.Weight.ToString() + " "
                + parameters.WalkingTime.ToString());
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Equals(WineMinus))
            {
                drinkModel.WineCount--;
            }
            else if (button.Equals(BeerMinus))
            {
                drinkModel.BeerCount--;
            }
            else if (button.Equals(VodkaMinus))
            {
                drinkModel.VodkaCount--;
            }
            else
            {
                MessageBox.Show("Not supported");
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Equals(WinePlus))
            {
                drinkModel.WineCount++;
            }
            else if (button.Equals(BeerPlus))
            {
                drinkModel.BeerCount++;
            }
            else if (button.Equals(VodkaPlus))
            {
                drinkModel.VodkaCount++;
            }
            else
            {
                MessageBox.Show("Not supported");
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Sex sex = parameters.Sex;

            int beers = drinkModel.BeerCount;
            int wines = drinkModel.WineCount;
            int vodkas = drinkModel.VodkaCount;

            List<Alcohol> alcoholes = new List<Alcohol>();
            for (int i = 0; i < beers; i++)
            {
                alcoholes.Add(Alcohol.BEER);
            }
            for (int i = 0; i < wines; i++)
            {
                alcoholes.Add(Alcohol.WINE);
            }
            for (int i = 0; i < vodkas; i++)
            {
                alcoholes.Add(Alcohol.VODKA);
            }

            PromileCalculator calculator = new PromileCalculator(sex);

            double promiles = calculator.CalculatePromiles(alcoholes, parameters.Weight, parameters.DrinkingTime);
            bool isDrunk = promiles > 0.5;
            bool isFasterWalking = parameters.WalkingTime < (parameters.WaitingTime + parameters.RidingTime);

            bool[] alfaWdata = { isDrunk,isFasterWalking,sex==Sex.WOMAN,WantFast.IsChecked.Value,WantSafe.IsChecked.Value };

            DecisionAlgorithm algorithm = new DecisionAlgorithm();
            List<Result> result = algorithm.makeDecision(alfaWdata);

            foreach (Result res in result) 
            {
                MessageBox.Show(res.ToString());
            }

        }
    }
}