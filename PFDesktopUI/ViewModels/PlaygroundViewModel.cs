using Caliburn.Micro;
using PFDesktopUI.Library.Api;
using PFDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.ViewModels
{
    public class PlaygroundViewModel: Screen
    {

        private IPlaygroundEndpoint _playgroundEndpoint;
       
        private BindingList<PlaygroundModel> _playgrounds;

        public PlaygroundViewModel(IPlaygroundEndpoint playgroundEndpoint)
        {
            _playgroundEndpoint = playgroundEndpoint;
           
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            Playgrounds = new BindingList<PlaygroundModel>(await _playgroundEndpoint.GetAll());
        }



        public BindingList<PlaygroundModel> Playgrounds
        {
            get { return _playgrounds; }
            set { 
                _playgrounds = value;
                NotifyOfPropertyChange(() => Playgrounds);
            }
        }

    }
}
