using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace PDD.Client
{
	public class PassExamViewModel:ViewModelBase
	{
		public List<QuestionViewModel> Questions { get; set; }

		public List<QuestionViewModel> AnsweredQuestions { get; set; }

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

		public ICommand NextQuestion
		{
			get
			{
				return new RelayCommand(() =>
				{
					AnsweredQuestions.Add(_currentQuestion);
					Questions.Remove(_currentQuestion);
					//if (Questions != null)
				});
			}
		} 
	}
}