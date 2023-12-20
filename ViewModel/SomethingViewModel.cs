using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VocabVibe.Model;
using VocabVibe.Model.Event;
using VocabVibe.View;

namespace VocabVibe
{
    public class SomethingViewModel:Notify
    {
        public RelayCommand ExitCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    System.Windows.Application.Current.Shutdown();
                });
            }
        }
        
    }   
}
