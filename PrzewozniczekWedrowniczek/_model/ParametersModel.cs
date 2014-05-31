using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PrzewozniczekWedrowniczek
{
    class ParametersModel : INotifyPropertyChanged
    {
        private Sex sex;
        private double weight, waitingTime, ridingTime, walkingTime, drinkingTime;

        public Sex Sex 
        {
            get 
            {
                return sex;
            }
            set 
            {
                sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }
        public double WaitingTime 
        { 
            get
            {
                return waitingTime;
            }
            set
            {
                waitingTime = value;
                OnPropertyChanged("WaitingTime");
            }
        }
        public double RidingTime
        {
            get
            {
                return ridingTime;
            }
            set
            {
                ridingTime = value;
                OnPropertyChanged("RidingTime");
            }
        }
        public double WalkingTime 
        { 
            get
            {
                return walkingTime;
            }
            set
            {
                walkingTime = value;
                OnPropertyChanged("WalkingTime");
            }
        }
        public double DrinkingTime
        {
            get
            {
                return drinkingTime;
            }
            set
            {
                drinkingTime = value;
                OnPropertyChanged("DrinkingTime");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

