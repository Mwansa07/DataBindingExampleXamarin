﻿using System;
using System.ComponentModel;

namespace DataBindingExample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if(name == value)
                {
                    return;
                }

                name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayName));
            }

        }

        public string DisplayName => $"Display Name Entered is: {Name}.";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
