using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Domain.Mappers
{
    abstract public class Mapper<FROM, TO>
    {
        public TO Map (FROM item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Невозможно преобразовать пустые данные");
            }
            return MapImpl(item);
        }
        public List<TO> MapMany(List<FROM> items)
        {
            return items.Select(item => Map(item)).ToList();
        }
        protected abstract TO MapImpl(FROM item);
    }
}
