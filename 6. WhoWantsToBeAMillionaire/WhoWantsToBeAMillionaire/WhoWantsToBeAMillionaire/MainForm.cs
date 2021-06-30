using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class MainForm : Form
    {
        List<Question> _questions = new List<Question>();
        Random _random = new Random();
        int _level = 0;
        Question _currentQuestion;
        const string _connectionString = @"Data Source=.\millionaire.db";

        public MainForm()
        {
            InitializeComponent();
            StartGame();
        }

        private void ShowQuestion(Question question)
        {
            lblQuestion.Text = question.Text;
            btnAnswerA.Text = question.Answers[0];
            btnAnswerB.Text = question.Answers[1];
            btnAnswerC.Text = question.Answers[2];
            btnAnswerD.Text = question.Answers[3];
        }

        private Question GetQuestion(int level)
        {
            using (var cn = new SQLiteConnection(_connectionString))
            {
                cn.Open();

                using (var cmd = new SQLiteCommand($"SELECT * FROM questions WHERE level == {level} ORDER BY Random() LIMIT 1", cn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        dr.Read();

                        var question = new Question(new string[]
                        {
                            dr["Question"].ToString(),
                            dr["AnswerA"].ToString(),
                            dr["AnswerB"].ToString(),
                            dr["AnswerC"].ToString(),
                            dr["AnswerD"].ToString(),
                            dr["RightAnswer"].ToString(),
                            dr["Level"].ToString()
                        });
                        
                        return question;
                    }
                }
            }
        }

        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            foreach (Button btn in btns)
            {
                btn.Enabled = true;
            }

            _level++;
            _currentQuestion = GetQuestion(_level);
            ShowQuestion(_currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - _level;
        }

        private void StartGame()
        {
            _level = 0;
            NextStep();
        }

        private void OnBtnAnswerClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (_currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                NextStep();
            }
            else
            {
                MessageBox.Show("Неверный ответ!");
                StartGame();
            }
        }

        private void OnBtnFiftyFiftyClick(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            int count = 0;
            while (count < 2)
            {
                int n = _random.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != _currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }

            btnFiftyFifty.Enabled = false;
        }

        private void OnBtnChangeQuestionClick(object sender, EventArgs e)
        {
            _currentQuestion = GetQuestion(_level);
            ShowQuestion(_currentQuestion);

            btnChangeQuestion.Enabled = false;
        }
    }
}
