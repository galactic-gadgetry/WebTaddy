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
    /// Interaction logic for TimeSheetListHeaderCard.xaml
    /// </summary>
    public partial class TimeSheetListHeaderCard : UserControl
    {
        // Dependency Properties
        public static readonly DependencyProperty IsDayOffProperty =
            DependencyProperty.Register(
                nameof(IsDayOff),
                typeof(bool),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(false));

        public static readonly DependencyProperty ListHeaderProperty =
            DependencyProperty.Register(
                nameof(ListHeader),
                typeof(TimeSheetListHeader),
                typeof(TimeSheetListHeaderCard),
                new PropertyMetadata(null));

        
        /// <summary>
        /// True if the day is normally not a work day,
        /// false otherwise.
        /// </summary>
        public bool IsDayOff
        {
            get => (bool)GetValue(IsDayOffProperty);
            set => SetValue(IsDayOffProperty, value);
        }

        /// <summary>
        /// Object model for the card.
        /// </summary>
        public TimeSheetListHeader ListHeader
        {
            get => (TimeSheetListHeader)GetValue(ListHeaderProperty);
            set => SetValue(ListHeaderProperty, value);
        }



        public TimeSheetListHeaderCard()
        {
            InitializeComponent();
        }
    }
}
