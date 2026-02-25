using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using WebTaddy.Commands;
using WebTaddy.Models;

namespace WebTaddy.ViewModels
{
    class TimeSheetViewModel : ViewModelBase
    {

        public ObservableCollection<Project> Projects = new()
        {
            new Project() {Name = "KSC-LAB, DEV, & TEST CAPABILITY SUSTAIN", Wbs = "12345.67.89.10.11"},
            new Project() {Name = "CAPMAG", Wbs = "11.10.98.76.54321"},
        };


        public List<WeeklyTimeEntry> FirstWeekEntryLines { get; set; } = new();


        public double FirstWeekTotalHours { get; set; } = 0;


        public List<TimeSheetListHeader> FirstWeekListHeaders { get; set; } = new();


        public List<WeeklyTimeEntry> SecondWeekEntryLines { get; set; } = new();


        public List<TimeSheetListHeader> SecondWeekListHeaders { get; set; } = new();


        public double SecondWeekTotalHours { get; set; } = 0;


        public DateTime StartDate = new DateTime(2026,1,11);


        public double PeriodTotalHours { get; set; } = 0;



        public ICommand CalculateButtonClickedCommand { get; }



        public TimeSheetViewModel()
        {
            InitializeEntryLines();
            InitializeListHeaders();


            CalculateButtonClickedCommand = new RelayCommand(
                new Action<object?>(OnCalculateButtonClicked));
        }



        private void InitializeEntryLines()
        {
            foreach(Project p in Projects)
            {
                FirstWeekEntryLines.Add(new WeeklyTimeEntry(p));
                SecondWeekEntryLines.Add(new WeeklyTimeEntry(p));
            }
        }


        private void InitializeListHeaders()
        {
            for (int i = 0; i < 7; i++)
            {
                FirstWeekListHeaders.Add(new(StartDate.AddDays(i)));
            }

            for (int i = 7; i < 14; i++)
            {
                SecondWeekListHeaders.Add(new(StartDate.AddDays(i)));
            }
        }


        private void OnCalculateButtonClicked(object? obj)
        {
            UpdateTotalHours();
        }


        private void UpdateDayTotalHours()
        {
            return;
        }


        private void UpdateEntryTotalHours()
        {
            foreach (WeeklyTimeEntry w in FirstWeekEntryLines)
            {
                w.SumEntries();
            }

            foreach (WeeklyTimeEntry w in SecondWeekEntryLines)
            {
                w.SumEntries();
            }
        }


        private void UpdateTotalHours()
        {
            UpdateDayTotalHours();
            UpdateEntryTotalHours();
        }
    }
}
