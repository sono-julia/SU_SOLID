using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Presentation.Api
{
    public interface IAddView
    {
        //какие методы тут вообще нужны? и чем эти интерфейсы отличаются от Main?
        public void Start();
        public void Show();
        public void End();
        public void AddButtonClick(object sender, EventArgs e);
    }
}
