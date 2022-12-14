using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Domain;
using SU_Dictionary.Domain.Api;
using SU_Dictionary.Presentation.Api;

namespace SU_Dictionary.Presentation
{
    public class MainPresenter
    {
        private IMainView view;
        private ITranslateUserCase useCase;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            useCase = new TranslateUserCase();
        }
        public void OnStart()
        {
            List<string> data = useCase.GetMyTranslatins();
            //можно исп. реактивное программирование

            view.Show("что-то сюда передать");
        }
    }
}
