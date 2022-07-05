﻿using System;
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
using System.Data;
using WpfApp1;

namespace WpfApp_1.MVVM.View
{
    /// <summary>
    /// Interaction logic for BookingView.xaml
    /// </summary>
    public partial class BookingView : UserControl
    {
        public BookingView()
        {
            InitializeComponent();


        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }




        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string Phone = txtPhone.Text;
            string Email = txtMail.Text;
            string BirthDate = txtDate.Text;
            DateTime? CheckIn = datePicker1.SelectedDate;
            DateTime? CheckOut = datePicker2.SelectedDate;

            int room_type = 0;
            if (btnStandard.IsChecked == true)
            {
                room_type = 1;
            }
            else if (btnSuperior.IsChecked == true)
            {
                room_type = 3;
            }
            else if (btnDeluxe.IsChecked == true)
            {
                room_type = 2;
            }
            else
            {
                ErrorLabel.Content = "Wypełnij wszystkie dane!";
            }
            int paymentMethod = 0;
            if (btnByCard.IsChecked == true)
            {
                paymentMethod = 2;
            }
            else if (btnByCash.IsChecked == true)
            {
                paymentMethod = 1;
            }
            else
            {
                ErrorLabel.Content = "Wypełnij wszystkie dane!";
            }


            if (Name != "" || Surname != "" || Phone != "" || Email != "" || BirthDate != "" || room_type != 0 || paymentMethod != 0 || CheckIn != null || CheckOut != null)
            {

           









            }
            else
            {
                ErrorLabel.Content = "Wypełnij wszystkie dane!";
            }














            // This block sets the TextBlock to a sensible default if dates haven't been picked
            if (!datePicker1.SelectedDate.HasValue || !datePicker2.SelectedDate.HasValue)
            {
                textBlock10.Text = "Wybierz daty";
                return;
            }

            // Because the nullable SelectedDate properties must have a value to reach this point, 
            // we can safely reference them - otherwise, these statements throw, as you've discovered.
            DateTime start = datePicker1.SelectedDate.Value.Date;
            DateTime finish = datePicker2.SelectedDate.Value.Date;
            TimeSpan difference = finish.Subtract(start);


            int daysCount = Int32.Parse(difference.TotalDays.ToString());
            if (daysCount > 0)
            {
                textBlock10.Text = difference.TotalDays.ToString();
                
            }
            else
            {
                textBlock10.Text = "* Wybierz daty poprawnie";
            }



         






        }

        public void Standard_Checked(object sender, RoutedEventArgs e)
        {
            if (!datePicker1.SelectedDate.HasValue || !datePicker2.SelectedDate.HasValue)
            {
                showPrice.Text = "Wybierz termin";
                return;
            }

            DateTime start = datePicker1.SelectedDate.Value.Date;
            DateTime finish = datePicker2.SelectedDate.Value.Date;
            TimeSpan difference = finish.Subtract(start);


            int daysCount = Int32.Parse(difference.TotalDays.ToString());
            int price = 300;
            int finalPrice = price * daysCount;
            if (daysCount > 0)
            {
                showPrice.Text = finalPrice.ToString() + " zł";

            }
            else
            {
                showPrice.Text = "- - - -";
            }
            
        }

        public void Superior_Checked(object sender, RoutedEventArgs e)
        {
            if (!datePicker1.SelectedDate.HasValue || !datePicker2.SelectedDate.HasValue)
            {
                showPrice.Text = "Wybierz termin";
                return;
            }

            DateTime start = datePicker1.SelectedDate.Value.Date;
            DateTime finish = datePicker2.SelectedDate.Value.Date;
            TimeSpan difference = finish.Subtract(start);


            int daysCount = Int32.Parse(difference.TotalDays.ToString());
            int price = 500;
            int finalPrice = price * daysCount;
            if (daysCount > 0)
            {
                showPrice.Text = finalPrice.ToString() + " zł";

            }
            else
            {
                showPrice.Text = "- - - -";
            }

        }

        public void Deluxe_Checked(object sender, RoutedEventArgs e)
        {
            if (!datePicker1.SelectedDate.HasValue || !datePicker2.SelectedDate.HasValue)
            {
                showPrice.Text = "Wybierz termin";
                return;
            }

            DateTime start = datePicker1.SelectedDate.Value.Date;
            DateTime finish = datePicker2.SelectedDate.Value.Date;
            TimeSpan difference = finish.Subtract(start);


            int daysCount = Int32.Parse(difference.TotalDays.ToString());
            int price = 700;
            int finalPrice = price * daysCount;
            if (daysCount > 0)
            {
                showPrice.Text = finalPrice.ToString() +" zł";

            }
            else
            {
                showPrice.Text = "- - - -";
            }
        }

        public void checkPrice(object sender, RoutedEventArgs e)
        {
            if (btnStandard.IsChecked == true)
            {
                btnStandard.IsChecked = false;
                btnStandard.IsChecked = true;
            }
            else if (btnSuperior.IsChecked == true)
            {
                btnSuperior.IsChecked = false;
                btnSuperior.IsChecked = true;
            }
            else if (btnDeluxe.IsChecked == true)
            {
                btnDeluxe.IsChecked = false;
                btnDeluxe.IsChecked = true;
            }
        }

        public void payByCash(object sender, RoutedEventArgs e)
        {

        }

        public void payByCard(object sender, RoutedEventArgs e)
        {

        }
    }
    }
