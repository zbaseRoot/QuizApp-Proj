using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ServerApp.Database;

namespace ServerApp
{
    public class DatabaseManager
    {
        private DbContextOptions<AppDbContext> _options;
        private int _currentUserId;

        public DatabaseManager()
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _options = optionsBuilder.Options;

            using (var db = new AppDbContext(_options))
            {
                db.Database.EnsureCreated();
            }
        }

        public bool LoginUser(string username, string password)
        {
            using (var db = new AppDbContext(_options))
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    _currentUserId = user.Id;
                    return true;
                }
                return false;
            }
        }

        public bool RegisterUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return false;

            using (var db = new AppDbContext(_options))
            {
                if (db.Users.Any(u => u.Username == username)) return false;

                db.Users.Add(new User { Username = username, Password = password });
                db.SaveChanges();
                return true;
            }
        }

        public void CreateQuiz(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;

            using (var db = new AppDbContext(_options))
            {
                db.Quizzes.Add(new Quiz { Name = name, UserId = _currentUserId });
                db.SaveChanges();
            }
        }

        public List<string> GetQuizzes()
        {
            using (var db = new AppDbContext(_options))
            {
                return db.Quizzes
                    .Where(q => q.UserId == _currentUserId)
                    .Select(q => q.Name)
                    .ToList();
            }
        }

        public void CreateQuestion(string quizName, string text, string red, string blue, string yellow, string green, string correct)
        {
            using (var db = new AppDbContext(_options))
            {
                var quiz = db.Quizzes.FirstOrDefault(q => q.Name == quizName && q.UserId == _currentUserId);
                if (quiz != null)
                {
                    db.Questions.Add(new Question
                    {
                        Text = text,
                        OptionRed = red,
                        OptionBlue = blue,
                        OptionYellow = yellow,
                        OptionGreen = green,
                        CorrectOption = correct,
                        QuizId = quiz.Id
                    });
                    db.SaveChanges();
                }
            }
        }

        public void DeleteQuestion(int questionId)
        {
            using (var db = new AppDbContext(_options))
            {
                var question = db.Questions.FirstOrDefault(q => q.Id == questionId);
                if (question != null)
                {
                    db.Questions.Remove(question);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteQuiz(string quizName)
        {
            using (var db = new AppDbContext(_options))
            {
                var quiz = db.Quizzes.FirstOrDefault(q => q.Name == quizName && q.UserId == _currentUserId);
                if (quiz != null)
                {
                    db.Quizzes.Remove(quiz);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateQuestion(int questionId, string text, string red, string blue, string yellow, string green, string correct)
        {
            using (var db = new AppDbContext(_options))
            {
                var question = db.Questions.FirstOrDefault(q => q.Id == questionId);
                if (question != null)
                {
                    question.Text = text;
                    question.OptionRed = red;
                    question.OptionBlue = blue;
                    question.OptionYellow = yellow;
                    question.OptionGreen = green;
                    question.CorrectOption = correct;
                    db.SaveChanges();
                }
            }
        }

        public List<Question> GetQuestions(string quizName)
        {
            using (var db = new AppDbContext(_options))
            {
                var quiz = db.Quizzes.FirstOrDefault(q => q.Name == quizName && q.UserId == _currentUserId);
                if (quiz != null)
                {
                    return db.Questions.Where(q => q.QuizId == quiz.Id).ToList();
                }
                return new List<Question>();
            }
        }
    }
}