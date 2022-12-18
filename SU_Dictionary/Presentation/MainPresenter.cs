using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Domain;
using SU_Dictionary.Domain.Api;
using SU_Dictionary.Presentation.Api;
using SU_Dictionary.Domain.Apiimpl;
using SU_Dictionary.Domain.Model;

namespace SU_Dictionary.Presentation
{
    public class MainPresenter
    {
        private IMainView view;
        private ITranslateUserCase useCase;
        private ITranslateToEngUserCase translateToEngUserCase;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            useCase = new TranslateUserCase();
            translateToEngUserCase = new GoogleTranslateToEngUserCase();
        }
        public void OnStart()
        {
            List<string> data = useCase.GetMyTranslations();
            //можно исп. реактивное программирование
            //Translation data = translateToEngUserCase.GetTranslation("word");
            view.Show("что-то сюда передать");
        }
        public void AddWordTranslation()
        {

        }
    }
}
