using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for TimeSheetWeeklyEntryCard.xaml
    /// </summary>
    public partial class TimeSheetWeeklyEntryCard : UserControl
    {
        // Dependency Properties
        public static readonly DependencyProperty EntryLinesProperty =
            DependencyProperty.Register(
                nameof(EntryLines),
                typeof(List<WeeklyTimeEntry>),
                typeof(TimeSheetWeeklyEntryCard),
                new PropertyMetadata(null));

        public static readonly DependencyProperty ListHeadersProperty =
            DependencyProperty.Register(
                nameof(ListHeaders),
                typeof(List<TimeSheetListHeader>),
                typeof(TimeSheetWeeklyEntryCard),
                new PropertyMetadata(null));

        public static readonly DependencyProperty TotalRowTextProperty =
            DependencyProperty.Register(
                nameof(TotalRowText),
                typeof(string),
                typeof(TimeSheetWeeklyEntryCard),
                new PropertyMetadata(string.Empty));


        /// <summary>
        /// Collection of object models for the list headers.
        /// </summary>
        public List<WeeklyTimeEntry> EntryLines
        {
            get => (List<WeeklyTimeEntry>)GetValue(EntryLinesProperty);
            set => SetValue(EntryLinesProperty, value);
        }

        /// <summary>
        /// Collection of the object models for the list headers.
        /// </summary>
        public List<TimeSheetListHeader> ListHeaders
        {
            get => (List<TimeSheetListHeader>)GetValue(ListHeadersProperty);
            set => SetValue(ListHeadersProperty, value);
        }

        /// <summary>
        /// Text for the week total row.
        /// </summary>
        public string TotalRowText
        {
            get => (string)GetValue(TotalRowTextProperty);
            set => SetValue(TotalRowTextProperty, value);
        }



        public TimeSheetWeeklyEntryCard()
        {
            InitializeComponent();
        }
    }
}
