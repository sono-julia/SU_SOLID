using SU_Dictionary.Domain.Api;
using SU_Dictionary.Domain.Apiimpl;
using SU_Dictionary.Presentation.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Presentation
{
    public class AddPresenter
    {
        private IAddView view;
        private ITranslateUserCase useCase;
        private ITranslateToEngUserCase translateToEngUserCase;
        public AddPresenter(IAddView view)
        {
            this.view = view;
            useCase = new TranslateUserCase();
            translateToEngUserCase = new GoogleTranslateToEngUserCase();
        }
        public void OnStart()
        {
            //Обратиться к модели, чтобы добавить перевод
        }
    }
}
