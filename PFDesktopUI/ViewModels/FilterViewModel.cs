using Caliburn.Micro;
using PFDesktopUI.Library.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDesktopUI.ViewModels
{
    public class FilterViewModel : Screen
    {
        //TODO: Move the labels to localized strings. 
        private BindingList<string> _ageFilter;
        private string _ageLabel = "Age Group";
        private BindingList<string> _accessiiblityFilter;
        private string _accessibilityLabel = "Accessibility";
        private BindingList<string> _groundCoverFilter;
        private string _groundCoverLabel = "Ground Cover";
        private BindingList<string> _sizeFilter;
        private string _sizeLabel = "Size";
        private BindingList<string> _quadrantFilter;
        private string _quadrantLabel = "Quadrant";
        private IFilterFieldEndpoint _filterFieldEndpoint;

        public FilterViewModel(IFilterFieldEndpoint filterFieldEndpoint)
        {
            _filterFieldEndpoint = filterFieldEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadFilters();
        }

        private async Task LoadFilters()
        {
            var result = await _filterFieldEndpoint.GetFilter("AgeFilter");
            result.Insert(0,_ageLabel);
            AgeFilter = new BindingList<string>(result);

            result = await _filterFieldEndpoint.GetFilter("AccessibilityFilter");
            result.Insert(0, _accessibilityLabel);
            AccessibilityFilter = new BindingList<string>(result);

            result = await _filterFieldEndpoint.GetFilter("GroundCoverFilter");
            result.Insert(0, _groundCoverLabel);
            GroundCoverFilter = new BindingList<string>(result);

            result = await _filterFieldEndpoint.GetFilter("SizeFilter");
            result.Insert(0, _sizeLabel);
            SizeFilter = new BindingList<string>(result);

            result = await _filterFieldEndpoint.GetFilter("QuadrantFilter");
            result.Insert(0, _quadrantLabel);
            QuadrantFilter = new BindingList<string>(result);

        }

        public BindingList<string> AgeFilter
        {
            get
            {
                return _ageFilter;
            }
            set
            {
                _ageFilter = value;
                NotifyOfPropertyChange(() => AgeFilter);
            }
        }

        public BindingList<string> AccessibilityFilter
        { 
            get
            {
                return _accessiiblityFilter;
            }
            set
            {
                _accessiiblityFilter = value;
                NotifyOfPropertyChange(() => AccessibilityFilter);
            } 
        }

        public BindingList<string> GroundCoverFilter
        {
            get
            {
                return _groundCoverFilter;
            }
            set
            {
                _groundCoverFilter = value;
                NotifyOfPropertyChange(() => GroundCoverFilter);
            }
        }

        public BindingList<string> SizeFilter
        {
            get
            {
                return _sizeFilter;
            }
            set
            {
                _sizeFilter = value;
                NotifyOfPropertyChange(() => SizeFilter);
            }
        }

        public BindingList<string> QuadrantFilter
        {
            get
            {
                return _quadrantFilter;
            }
            set
    {
                _quadrantFilter = value;
                NotifyOfPropertyChange(() => QuadrantFilter);
            }
        }

    }
}
