using SU_Dictionary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Domain.Api;
using SU_Dictionary.Entity;

namespace SU_Dictionary.Domain.Apiimpl
{
    public class YandexTranslateToEngUserCase : ITranslateToEngUserCase
    {
        private IYandexTranslateRepo repo;
        public Translation GetTranslation(string word)
        {
            //как получить перевод
            repo.Translate(word); //но надо преобразовать
            return null;
        }
    }
}
