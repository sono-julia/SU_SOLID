using SU_Dictionary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Domain.Api
{
    public interface ITranslateToEngUserCase
    {
        Translation GetTranslation(string word);
        //перевод слова, перевод текста, перевод фразы, определение языка
    }

}
