using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Domain.Api
{
    public interface ITranslateUserCase
    {
        List<string> GetMyTranslations();
    }
}
