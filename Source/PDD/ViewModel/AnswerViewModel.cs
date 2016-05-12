using GalaSoft.MvvmLight;

namespace PDD.Client
{
    public class AnswerViewModel: ViewModelBase
    {
        private string _name;
        private bool _right;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public bool Right
        {
            get { return _right; }
            set
            {
                _right = value;
                RaisePropertyChanged(() => Right);
            }
        }
    }
}