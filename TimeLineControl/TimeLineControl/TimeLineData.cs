using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace TimeLineControl
{
    public class TimeLineData : MyObservableObject
    {
        private ObservableCollection<TimeLineEntry> entries = new ObservableCollection<TimeLineEntry>();
        public TimeLineData(DurationUnit durationUnit, int totalDuration, double minEntryDuration)
        {
            this.Initialize(durationUnit, totalDuration, minEntryDuration);
            entries.CollectionChanged += Entries_CollectionChanged;
        }

        public TimeLineData()
        {
            this.Initialize(DurationUnit.Seconds, 5, 0.3);
            entries.CollectionChanged += Entries_CollectionChanged;
        }

        public DurationUnit DurationUnit { get; set; }

        private void Entries_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("Entries");
        }


        #region Total duration
        private TimeSpan _TotalDuration;
        /// <summary>
        /// TotalDuration: Total duration
        /// </summary>
        public TimeSpan TotalDuration
        {
            get => _TotalDuration;
            set
            {
                _TotalDuration = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Duración mínima, 
        private double _MinEntryDuration;
        /// <summary>
        /// MinEntryDuration: Duración mímina de la entrada 
        /// </summary>
        public double MinEntryDuration
        {
            get => _MinEntryDuration;
            set
            {
                _MinEntryDuration = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public ObservableCollection<TimeLineEntry> Entries
        {
            get
            {
                return entries;
            }
            set
            {
                if (entries == value)
                    return;

                if (entries != null)
                    entries.CollectionChanged -= Entries_CollectionChanged;

                entries = value;
                OnPropertyChanged();
            }
        }


    }
}
