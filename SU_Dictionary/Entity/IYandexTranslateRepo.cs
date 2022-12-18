using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Entity.Dto;

namespace SU_Dictionary.Entity
{
    public interface IYandexTranslateRepo
    {
        YandexTranslateDto Translate(string word);
    }
}
