using Caliburn.Micro;
using PFDesktopUI.Library.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<LogInEvent>, IHandle<FilterEvent>
    {
     
        private IEventAggregator _events;
        private FilterViewModel _filterVM;
        private PlaygroundViewModel _playgroundVM;
        private SimpleContainer _container;

        public ShellViewModel( IEventAggregator events, FilterViewModel filterVM, SimpleContainer container, PlaygroundViewModel playgroundVM)
        {
            _filterVM = filterVM;
            _playgroundVM = playgroundVM;
            _container = container;

            _events = events;
            _events.Subscribe(this);

            ActivateItem(container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogInEvent message)
        {
            ActivateItem(_filterVM);
        }

        public void Handle(FilterEvent message)
        {
            ActivateItem(_playgroundVM);
        }
    }
}
