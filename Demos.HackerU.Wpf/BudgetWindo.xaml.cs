using Demos.HackerU.Wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Demos.HackerU.Wpf.Business_Logic;
using Demos.HackerU.HomeWork.HW_18.Ef;
using Demos.HackerU.HomeWork.Inhheritance;

namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for BudgetWindo.xaml
    /// </summary>
    public partial class BudgetWindo : Window
    {
        public BudgetWindo()
        {
            InitializeComponent();
            DataContext = this;

            double balance = 1600;
            RemainingBalance = $"${balance}";

            budgets = new ObservableCollection<Budget>();
        }
        public string RemainingBalance { get; set; }

        public ObservableCollection<Budget> budgets;



        private void NewBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetStackPanel.Visibility == Visibility.Collapsed)
            {
                BudgetStackPanel.Visibility = Visibility.Visible;

            }

        }

        private void CreateBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = BudgetValidation.ValidateBudget(TotalBudgetTextBox.Text, StartDatePicker.SelectedDate, EndDatePicker.SelectedDate);

            if (errorMessage != "")
            {
                ShowError(errorMessage);
                return;
            }

            Budget budget = new Budget
            {
                StartDate = (DateTime)StartDatePicker.SelectedDate,
                EndDate = (DateTime)EndDatePicker.SelectedDate,
                BudgetAmount = double.Parse(TotalBudgetTextBox.Text)
            };
            BudgetRepository.AddNewBudgetToDb(budget);
            BudgetListView.ItemsSource = BudgetRepository.GetAllBudget();

            ShowSuccess();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateFlyout.IsOpen = true;
        }

        private void ShowError(string error)
        {
            UpdateFlyout.Background = Brushes.Red;

            FlyoutTextBlock.Text = error;

            UpdateFlyout.CloseButtonVisibility = Visibility.Hidden;

            UpdateFlyout.IsOpen = true;
        }

        private void ShowSuccess()
        {
            UpdateFlyout.Background = Brushes.Green;

            FlyoutTextBlock.Text = "Successfully Added Budget!";

            UpdateFlyout.CloseButtonVisibility = Visibility.Hidden;

            BudgetStackPanel.Visibility = Visibility.Collapsed;

            UpdateFlyout.IsOpen = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BudgetListView.ItemsSource = BudgetRepository.GetAllBudget();
        }
    }
}
