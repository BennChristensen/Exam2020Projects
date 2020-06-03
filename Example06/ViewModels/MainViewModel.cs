using Example06.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Food> Foods { get; set; }
        public Food Food { get; set; }
    }
}
