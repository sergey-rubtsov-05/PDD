using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PDD.DataModel.Entity;
using PDD.EfDal;

namespace PDD.Client
{
    public class QuestionViewModel:ViewModelBase
    {
        public QuestionViewModel()
        {
            Answers = new ObservableCollection<AnswerViewModel>();
        }

        private string _name;
        private string _description;
        public string Name {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(()=>Name);
            } }
        public string Description {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
            }
        }

		public AnswerViewModel SelectedAnswer {get;set;}

        public ObservableCollection<AnswerViewModel> Answers { get; set; }

        private ICommand _save;
        public ICommand Save
        {
            get
            {
                return _save = new RelayCommand(() =>
                {
                    List<Answer> list = Answers.Select(x=> new Answer
                    {
                        Name = x.Name,
                        Right = x.Right
                    }).ToList();
                    var repository = new QuestionRepository();
                    repository.Save(new Question
                    {
                        Name = Name,
                        Description = Description,
                        Answers = list,
                        TestId = 1
                    });
                    Name=string.Empty;
                    Description=String.Empty;
                    Answers.Clear();
                });
            }
        }

        private string _answerName;

        public string AnswerName
        {
            get { return _answerName; }
            set
            {
                _answerName = value;
                RaisePropertyChanged(() => AnswerName);
            }
        }

        private int _right;

        public int Right
        {
            get { return _right; }
            set
            {
                _right = value;
                RaisePropertyChanged(()=>Right);
            }
        }

        private ICommand _addAnswer;
        public ICommand AddAnswer
        {
            get
            {
                return _addAnswer = new RelayCommand(() =>
                {
                    Answers.Add(new AnswerViewModel
                    {
                        Name = AnswerName,
                        Right = Right
                    });
                    AnswerName = string.Empty;
                    Right = 0;
                });
            }
        }
    }
}