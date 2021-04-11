using MHRArmorBuilder.Core;

namespace MHRArmorBuilder.ViewModels
{
    class MainViewModel : BindableBase
    {
        private ConstraintViewModel _constraintViewModel;
        private ResultViewModel _resultViewModel;

        public MainViewModel(ConstraintViewModel constraintViewModel,
            ResultViewModel resultViewModel)
        {
            ConstraintViewModel = constraintViewModel;
            ResultViewModel = resultViewModel;
        }

        public ConstraintViewModel ConstraintViewModel
        {
            get => _constraintViewModel;
            private init
            {
                if (_constraintViewModel == value) return;
                _constraintViewModel = value;
                RaisePropertyChanged();
            }
        }

        public ResultViewModel ResultViewModel
        {
            get => _resultViewModel;
            private init
            {
                if (_resultViewModel == value) return;
                _resultViewModel = value;
                RaisePropertyChanged();
            }
        }
    }
}