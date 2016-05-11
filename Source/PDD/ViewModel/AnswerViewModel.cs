using GalaSoft.MvvmLight;

namespace PDD.Client
{
    public class AnswerViewModel: ViewModelBase
    {
        private string _name;
        private int _right;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public int Right
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