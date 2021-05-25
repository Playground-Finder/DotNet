using Caliburn.Micro;
using PFDesktopUI.Library.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<LogInEvent>
    {
     
        private IEventAggregator _events;
        private FilterViewModel _filterVM;
        private SimpleContainer _container;

        public ShellViewModel( IEventAggregator events, FilterViewModel filterVM, SimpleContainer container)
        {
            _filterVM = filterVM;
            _container = container;

            _events = events;
            _events.Subscribe(this);

            ActivateItem(container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogInEvent message)
        {
            ActivateItem(_filterVM);
        }
    }
}
