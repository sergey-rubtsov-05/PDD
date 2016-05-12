using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PDD.DataModel.Entity;
using PDD.EfDal;

namespace PDD.Client
{
    public class GenerateData
    {
        public static void GenerateForDb()
        {
            PddDbContext context = new PddDbContext();
            context.Persons.Add(new Person
            {
                LastName = "Петров",
                FirstName = "Петр",
                Patronymic = "Петрович",
                Id = 1
            });
            context.Persons.Add(new Person
            {
                LastName = "Семенов",
                FirstName = "Семен",
                Patronymic = "Семеныч",
                Id = 2
            });
            context.Persons.Add(new Person
            {
                LastName = "Иванов",
                FirstName = "Иван",
                Patronymic = "Иванович",
                Id = 3
            });
            context.Persons.Add(new Person
            {
                LastName = "Ахметов",
                FirstName = "Ахмет",
                Patronymic = "Ахметович",
                Id = 4
            });
            context.Persons.Add(new Person
            {
                LastName = "Петров",
                FirstName = "Петр",
                Patronymic = "Петрович",
                Id = 5
            });
            context.SaveChanges();
        }
        private static void GenerateForXML()
        {
            var testIds = new List<int> { 1, 2 };
            var questionIds = new List<int> { 1, 2, 3 };
            var tests = new List<Test>();
            var answer1 = new Answer
            {
                Name = "Все автобусы.",
                Right = false,
                QuestionId = questionIds[0],
                id = 1
            };
            var answer2 = new Answer
            {
                Name = "Автобусы, троллейбусы и трамваи, предназначенные для перевозки людей и движущиеся по установленному маршруту с обозначенными местами остановок.",
                Right = true,
                QuestionId = questionIds[0],
                id = 2
            };
            var answer3 = new Answer
            {
                Name = "Любые транспортные средства, перевозящие пассажиров.",
                Right = false,
                QuestionId = questionIds[0],
                id = 3
            };

            var question1 = new Question
            {
                Description = "",
                Name = "Какие транспортные средства по Правилам относятся к маршрутным транспортным средствам?",
                TestId = testIds[0],
                Id = questionIds[0],
                Answers = new List<Answer>
                {
                    answer1, answer2, answer3
                }
            };

            var answer21 = new Answer
            {
                Name = "Запрещает дальнейшее движение.",
                Right = false,
                QuestionId = questionIds[1],
                id = 4
            };
            var answer22 = new Answer
            {
                Name = "Автобусы, троллейбусы и трамваи, предназначенные для перевозки людей и движущиеся по установленному маршруту с обозначенными местами остановок.",
                Right = true,
                QuestionId = questionIds[1],
                id = 5
            };
            var answer23 = new Answer
            {
                Name = "Любые транспортные средства, перевозящие пассажиров.",
                Right = false,
                QuestionId = questionIds[1],
                id = 6
            };

            var question2 = new Question
            {
                Description = "",
                Name = "Что означает мигание зеленого сигнала светофора?",
                TestId = testIds[0],
                Id = questionIds[1],
                Answers = new List<Answer>
                {
                    answer21, answer22, answer23
                }
            };

            tests.Add(new Test
            {
                Description = "Тест",
                Id = testIds[0],
                Questions = new List<Question>
                {
                    question1, question2
                }
            });

            WriteToXmlFile<Test>(tests, "testQuestions.xml");

            var persons = new List<Person>();
            persons.Add(new Person
            {
                LastName = "Петров",
                FirstName = "Петр",
                Patronymic = "Петрович",
                Id = 1
            });
            persons.Add(new Person
            {
                LastName = "Семенов",
                FirstName = "Семен",
                Patronymic = "Семеныч",
                Id = 2
            });
            persons.Add(new Person
            {
                LastName = "Иванов",
                FirstName = "Иван",
                Patronymic = "Иванович",
                Id = 3
            });
            persons.Add(new Person
            {
                LastName = "Ахметов",
                FirstName = "Ахмет",
                Patronymic = "Ахметович",
                Id = 4
            });
            persons.Add(new Person
            {
                LastName = "Петров",
                FirstName = "Петр",
                Patronymic = "Петрович",
                Id = 5
            });
            WriteToXmlFile(persons, "persons.xml");
        }

        public static void WriteToXmlFile<T>(List<T> objects, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            new XmlSerializer(typeof(List<T>)).Serialize(writer, objects);
            writer.Close();
        }

        public static Person[] ReadPersonsFromXmlFile()
        {
            Person[] persons = null;
            string path = "Persons.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(fs);
            reader.ReadToEnd();
            persons = (Person[])serializer.Deserialize(reader);
            fs.Close();

            return persons;
        }

        public static Test[] ReadTestsFromXmlFile()
        {
            Test[] tests = null;
            string path = "testQuestions.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Test[]));

            StreamReader reader = new StreamReader(path);
            reader.ReadToEnd();
            tests = (Test[])serializer.Deserialize(reader);
            reader.Close();

            return tests;
        }

		public static void AddDataToDatabase()
		{
			//var testIds = new List<int> { 1, 2 };
			//var questionIds = new List<int> { 1, 2, 3 };
			//var test = new List<Test>();
			var answer1 = new Answer
			{
				Name = "Все автобусы.",
				Right = false,
				//QuestionId = questionIds[0],
				id = 1
			};
			var answer2 = new Answer
			{
				Name = "Автобусы, троллейбусы и трамваи, предназначенные для перевозки людей и движущиеся по установленному маршруту с обозначенными местами остановок.",
				Right = true,
				//QuestionId = questionIds[0],
				id = 2
			};
			var answer3 = new Answer
			{
				Name = "Любые транспортные средства, перевозящие пассажиров.",
				Right = false,
				//QuestionId = questionIds[0],
				id = 3
			};

			var question1 = new Question
			{
				Description = "",
				Name = "Какие транспортные средства по Правилам относятся к маршрутным транспортным средствам?",
				//TestId = testIds[0],
				//Id = questionIds[0],
				Answers = new List<Answer>
				{
					answer1, answer2, answer3
				}
			};

			var answer21 = new Answer
			{
				Name = "Запрещает дальнейшее движение.",
				Right = false,
				//QuestionId = questionIds[1],
				id = 4
			};
			var answer22 = new Answer
			{
				Name = "Автобусы, троллейбусы и трамваи, предназначенные для перевозки людей и движущиеся по установленному маршруту с обозначенными местами остановок.",
				Right = true,
				//QuestionId = questionIds[1],
				id = 5
			};
			var answer23 = new Answer
			{
				Name = "Любые транспортные средства, перевозящие пассажиров.",
				Right = false,
				//QuestionId = questionIds[1],
				id = 6
			};

			var question2 = new Question
			{
				Description = "",
				Name = "Что означает мигание зеленого сигнала светофора?",
				//TestId = testIds[0],
				//Id = questionIds[1],
				Answers = new List<Answer>
				{
					answer21, answer22, answer23
				}
			};

			var test = new Test
			{
				Description = "Тест",
				//id = testIds[0],
				Questions = new List<Question>
				{
					question1, question2
				}
			};

			var repository = new TestRepository();
			repository.Save(test);
		}
    }
}