using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SU_Dictionary.Domain.Api;

namespace SU_Dictionary.Domain.Apiimpl
{
    public class TranslateUserCase : ITranslateUserCase
    {
        public List<string> GetMyTranslatins()
        {
            List<string> data = new List<string>(); //временно, нужен запрос к БД
            return data;
        }
    }
}

