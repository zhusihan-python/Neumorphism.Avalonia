﻿using Avalonia.Data;
using System;

namespace Neumorphism.Avalonia.Demo.ViewModels
{
    public class DateTimePickersDemoViewModel : ViewModelBase
    {
        private DateTime? _birthDate;
        public DateTime? BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value.HasValue)
                {
                    if (value < DateTime.Today)
                    {
                        _birthDate = value;
                        OnPropertyChanged(nameof(BirthDate));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid birth date");
                    }
                }
            }
        }




        private DateTime? _dateStart;
        public DateTime? DateStart
        {
            get { return _dateStart; }
            set
            {
                if (value.HasValue)
                {
                    if (!DateEnd.HasValue || (DateEnd.HasValue && value < DateEnd.Value))
                    {
                        _dateStart = value;
                        OnPropertyChanged(nameof(DateStart));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid start date");
                    }
                }
            }
        }

        private DateTime? _dateEnd;
        public DateTime? DateEnd
        {
            get { return _dateEnd; }
            set
            {
                if (value.HasValue)
                {
                    if (!DateStart.HasValue || (DateStart.HasValue && value > DateStart.Value))
                    {
                        _dateEnd = value;
                        OnPropertyChanged(nameof(DateEnd));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid end date");
                    }
                }
            }
        }



        private TimeSpan? _meetingTime;
        public TimeSpan? MeetingTime
        {
            get { return _meetingTime; }
            set
            {
                if (value.HasValue)
                {
                    if (value < new TimeSpan(12, 0, 0))
                    {
                        _meetingTime = value;
                        OnPropertyChanged(nameof(MeetingTime));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid meeting time");
                    }
                }
            }
        }


        private TimeSpan? _timeStart;
        public TimeSpan? TimeStart
        {
            get { return _timeStart; }
            set
            {
                if (value.HasValue)
                {
                    if (!TimeStart.HasValue || (TimeStart.HasValue && value > TimeStart.Value))
                    {
                        _timeStart = value;
                        OnPropertyChanged(nameof(TimeStart));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid start time !");
                    }
                }
            }
        }

        private TimeSpan? _timeEnd;
        public TimeSpan? TimeEnd
        {
            get { return _timeEnd; }
            set
            {
                if (value.HasValue)
                {
                    if (!TimeStart.HasValue || (TimeStart.HasValue && value > TimeStart.Value))
                    {
                        _timeEnd = value;
                        OnPropertyChanged(nameof(TimeEnd));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid end time !");
                    }
                }
            }
        }

        private string _test;
        public string Test
        {
            get { return _test; }
            set
            {
                if (value != "aaa")
                {
                    _test = value;
                    OnPropertyChanged(nameof(Test));
                }
                else
                {
                    throw new DataValidationException("Invalid string !");
                }
            }
        }
    }
}