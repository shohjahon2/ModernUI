using ModernUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.MVVM.ViewModel
{
    public class MainViewModel: ObresvableObject
    {
        public RelayCommand HomewViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        private HomeViewModel HomeVM { get; set; }
        private DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;

            HomewViewCommand = new RelayCommand(o=>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o=>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
