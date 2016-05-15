using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace PDD.Client
{
	public class PassExamViewModel:ViewModelBase
	{
		public List<QuestionViewModel> Questions { get; set; }

		private QuestionViewModel _currentQuestion;
		public QuestionViewModel CurrentQuestion
		{
			get
			{
				return _currentQuestion;
			}
			set
			{
				_currentQuestion = value;
				RaisePropertyChanged(()=>CurrentQuestion);
			}
		}

		private int _currentQuestionNumber;
		public int CurrentQuestionNumber
		{
			get
			{
				return _currentQuestionNumber+1;
			}
			set
			{
				_currentQuestionNumber = value;
				RaisePropertyChanged(() => CurrentQuestionNumber);
			}
		}

		public ICommand NextQuestion
		{
			get
			{
				return new RelayCommand(() =>
				{
					Questions[_currentQuestionNumber] = _currentQuestion;
					_currentQuestionNumber = _currentQuestionNumber + 1;
					CurrentQuestion = Questions[_currentQuestionNumber];
				});
			}
		} 
	}
}