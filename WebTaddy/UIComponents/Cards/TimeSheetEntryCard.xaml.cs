using System;
using System.Collections.Generic;
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
using WebTaddy.Models;

namespace WebTaddy.UIComponents.Cards
{
    /// <summary>
    /// Interaction logic for TimeSheetEntryCard.xaml
    /// </summary>
    public partial class TimeSheetEntryCard : UserControl
    {
        //Dependency Properties
        public static readonly DependencyProperty TimeEntryProperty =
            DependencyProperty.Register(
                nameof(TimeEntry),
                typeof(WeeklyTimeEntry),
                typeof(TimeSheetEntryCard),
                new PropertyMetadata(null));


        /// <summary>
        /// Object model for the card.
        /// </summary>
        public WeeklyTimeEntry TimeEntry
        {
            get => (WeeklyTimeEntry)GetValue(TimeEntryProperty);
            set => SetValue(TimeEntryProperty, value);
        }



        public TimeSheetEntryCard()
        {
            InitializeComponent();
        }
    }
}
