using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewozniczekWedrowniczek
{
    public class DrinkModel : INotifyPropertyChanged
    {
        private int beerCount = 0;
        private int wineCount = 0;
        private int vodkaCount = 0;

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int BeerCount
        {
            get
            {
                return beerCount;
            }
            set
            {
                if (value >= 0) beerCount = value; //to End
                OnPropertyChanged("BeerCount");
            }
        }

        public int WineCount
        {
            get { return wineCount;  }
            set
            {
                 if (value >= 0) wineCount = value;
                 OnPropertyChanged("WineCount");
            }
        }

        public int VodkaCount
        {
            get { return vodkaCount; }
            set
            {
                if (value >= 0) vodkaCount = value;
                OnPropertyChanged("VodkaCount");
            }
        }
    }
}
