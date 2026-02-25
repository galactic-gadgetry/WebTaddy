using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebTaddy.Models
{
    public class WeeklyTimeEntry : INotifyPropertyChanged
    {

        public enum EntrySubType
        {
            None,
            TWORK,
        }

        public enum EntryType
        {
            REG,
        }


        // Backing Fields
        private double totalHours = 0;

        
        public readonly DateOnly EndDate;

        /// <summary>
        /// Collection of hours for the week.
        /// </summary>
        public double[] Entries { get; set; } = new double[7];

        /// <summary>
        /// Text for the project name.
        /// </summary>
        public string ProjectName { get; set; } = string.Empty;

        /// <summary>
        /// Text for the project WBS code.
        /// </summary>
        public string ProjectWbs { get; set; } = string.Empty;

        
        public readonly DateOnly StartDate;

        
        public EntrySubType SubType { get; set; } = EntrySubType.None;

        
        public string SubTypeString => GetSubTypeString();

        /// <summary>
        /// Sum of entry hours.
        /// </summary>
        public double TotalHours
        {
            get => totalHours;
            set
            {
                totalHours = value;
                OnPropertyChanged(nameof(TotalHours));
            }
        }


        public EntryType Type { get; set; } = EntryType.REG;


        public string TypeString => GetTypeString();



        public event PropertyChangedEventHandler? PropertyChanged;



        public WeeklyTimeEntry(Project project)
        {
            ProjectName = project.Name;
            ProjectWbs = project.Wbs;
        }



        public string GetSubTypeString()
        {
            return SubType == EntrySubType.None ? string.Empty : SubType.ToString();
        }


        public string GetTypeString()
        {
            return Type.ToString();
        }


        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }


        public void SumEntries()
        {
            double sum = 0;
            foreach (double e in Entries)
            {
                sum += e;
            }

            TotalHours = sum;
        }
    }
}
