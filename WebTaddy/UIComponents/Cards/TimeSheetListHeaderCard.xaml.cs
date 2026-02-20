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

namespace WebTaddy.UIComponents.Cards
{
    /// <summary>
    /// Interaction logic for TimeSheetListHeaderCard.xaml
    /// </summary>
    public partial class TimeSheetListHeaderCard : UserControl
    {
        // Dependency Properties
        public static readonly DependencyProperty DateTextProperty =
            DependencyProperty.Register(
                nameof(DateText),
                typeof(string),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(null));

        public static readonly DependencyProperty DayOfWeekTextProperty =
            DependencyProperty.Register(
                nameof(DayOfWeekText),
                typeof(string),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(null));

        public static readonly DependencyProperty IsDayOffProperty =
            DependencyProperty.Register(
                nameof(IsDayOff),
                typeof(bool),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(false));

        public static readonly DependencyProperty RegularHoursTextProperty =
            DependencyProperty.Register(
                nameof(RegularHoursText),
                typeof(string),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata("0.0"));

        public static readonly DependencyProperty TeleworkHoursTextProperty =
            DependencyProperty.Register(
                nameof(TeleworkHoursText),
                typeof(string),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata("0.0"));

        public static readonly DependencyProperty TotalHoursTextProperty =
            DependencyProperty.Register(
                nameof(TotalHoursText),
                typeof(string),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(null));

        /// <summary>
        /// Text for the Date label.
        /// </summary>
        public string DateText
        {
            get => (string)GetValue(DateTextProperty);
            set => SetValue(DateTextProperty, value);
        }

        /// <summary>
        /// Text for the Day of Week label.
        /// </summary>
        public string DayOfWeekText
        {
            get => (string)GetValue(DayOfWeekTextProperty);
            set => SetValue(DayOfWeekTextProperty, value);
        }


        public bool IsDayOff
        {
            get => (bool)GetValue(IsDayOffProperty);
            set => SetValue(IsDayOffProperty, value);
        }

        /// <summary>
        /// Text for the Regular Hours text box.
        /// </summary>
        public string RegularHoursText
        {
            get => (string)GetValue(RegularHoursTextProperty);
            set => SetValue(RegularHoursTextProperty, value);
        }

        /// <summary>
        /// Text for the Telework Hours text box.
        /// </summary>
        public string TeleworkHoursText
        {
            get => (string)GetValue(TotalHoursTextProperty);
            set => SetValue(TotalHoursTextProperty, value);
        }

        /// <summary>
        /// Text for the Total Hours label.
        /// </summary>
        public string TotalHoursText
        {
            get => (string)GetValue(TotalHoursTextProperty);
            set => SetValue(TotalHoursTextProperty, value);
        }



        public TimeSheetListHeaderCard()
        {
            InitializeComponent();
        }
    }
}
