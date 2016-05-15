using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Autofac;
using PDD.DataModel.Entity;
using PDD.EfDal;
using PDD.Infrastructure;

namespace PDD.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            //Database.SetInitializer(new DropCreateDatabaseAlways<PddDbContext>());
			//GenerateData.AddDataToDatabase();
        }

        private void PassExam_OnClick(object sender, RoutedEventArgs e)
        {
			PassExamView card = new PassExamView();
			var repository = IocContainer.Instance.Container.Resolve<IGenericRepository<Question>>();
	        var questions = repository.GetList().ToList();
			var list = questions.Select(q=> new QuestionViewModel
			{
				Name = q.Name,
				Answers = new ObservableCollection<AnswerViewModel>(q.Answers.Select(a=>new AnswerViewModel
				{
					Name = a.Name,
					Right = a.Right
				}))
			});
			PassExamViewModel viewModel = new PassExamViewModel
			{
				Questions = list.ToList(),
				CurrentQuestion = list.FirstOrDefault(),
				CurrentQuestionNumber = 0
			};
	        card.DataContext = viewModel;
	        card.ShowDialog();
        }

        private void AddQuestion_OnClick(object sender, RoutedEventArgs e)
        {
            QuestionView card = new QuestionView();
            card.ShowDialog();
        }
    }
}
