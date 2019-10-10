using Odev.Web.ViewModels;
using System.Collections;
using System.Collections.Generic;

namespace Odev.Web.Services.Interfaces
{
    public interface IRandomUserService:IBaseService<RandomUserViewModel>
    {
        IList<ExamViewModel> GetAnswers();
        void AddAnswer(ExamViewModel model);
        ExamViewModel GetQuestion();        
        RandomUserViewModel GetById(string id);
        void AddList(IList<RandomUserViewModel> randomUserModel);
    }
}
