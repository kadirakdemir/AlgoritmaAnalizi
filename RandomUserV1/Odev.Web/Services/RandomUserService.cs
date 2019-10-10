using System;
using System.Collections.Generic;
using Odev.Web.Services.Interfaces;
using Odev.Web.ViewModels;

namespace Odev.Web.Services
{
    public class RandomUserService : BaseService<RandomUserViewModel>, IRandomUserService
    {
        public static Dictionary<int, string> _questions;
        public static IList<ExamViewModel> _examViewModels = new List<ExamViewModel>();
        public ExamViewModel _examViewModel = new ExamViewModel();
        private static int _rndNumber = 0;
        private static int _num = 0;

        public void AddList(IList<RandomUserViewModel> randomUserModel)
        {
            entities = randomUserModel;
        }

        public RandomUserViewModel GetById(string id)
        {
            foreach (var item in entities)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private void CreateQuestion()
        {
            _questions = new Dictionary<int, string>();
            _questions.Add(1, "Mesleğin nedir?");
            _questions.Add(2, "Nerelisin?");
            _questions.Add(3, "Kaç yaşındasın?");
            _questions.Add(4, "Tuttuğun takım?");
            _questions.Add(5, "Mezuniyet durumun nedir?");
        }

        public ExamViewModel GetQuestion()
        {
            CreateQuestion();

            Random random = new Random();
            _rndNumber = random.Next(1, 5);
            

            if (entities.Count>0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    if (entities[i].ExamIsActive == false)
                    {
                        _num = i;
                    }
                }

                _examViewModel.RandomUserViewModelId = entities[_num].Id;
                _examViewModel.RandomUserName = entities[_num].Name;
                _examViewModel.Question = _questions[_rndNumber];

                return _examViewModel;
            }            
            return null;
        }

        public void AddAnswer(ExamViewModel model)
        {
            entities[_num].ExamIsActive = true;
            model.RandomUserName = entities[_num].Name;
            model.Question = _questions[_rndNumber];
            model.InsertDate = DateTime.Now;
            _examViewModels.Add(model);
        }

        public IList<ExamViewModel> GetAnswers()
        {
            return _examViewModels;
        }
    }
}