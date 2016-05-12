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

		public ICommand NextQuestion
		{
			get
			{
				return new RelayCommand(() =>
				{
					var item = Questions.FirstOrDefault(q => q.Name == _currentQuestion.Name);
					if (item != null)
					{
						item.SelectedAnswer = _currentQuestion.SelectedAnswer;
					}
					_currentQuestion = Questions.FirstOrDefault(q => q.SelectedAnswer == null);
				});
			}
		} 
	}
}