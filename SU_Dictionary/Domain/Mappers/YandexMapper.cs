using SU_Dictionary.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Domain.Model;

namespace SU_Dictionary.Domain.Mappers
{
    public class YandexMapper : Mapper<YandexTranslateDto, Translation>
    {
        protected override Translation MapImpl(YandexTranslateDto item)
        {
            //TODO: реализовать преобразование dto в translation
            return null;
        }
    }
}
