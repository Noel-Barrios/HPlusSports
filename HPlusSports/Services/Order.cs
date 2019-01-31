﻿using System;
using System.ComponentModel;

namespace HPlusSports.Services
{
    public class Order : INotifyPropertyChanged
    {
        public Order()
        {
        }

        public string ProductName
        {
            get;
            set;
        }

        private int qty;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Quantity
        {
            get { return qty; }
            set
            {
                if(value != qty)
                {
                    qty = value;
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
                }
            }
        }


    }
}
