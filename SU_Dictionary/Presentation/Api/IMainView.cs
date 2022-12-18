using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU_Dictionary.Presentation.Api
{
    public interface IMainView
    {
        public void Start();

        public void Show(string message);

        public void ShowError(Exception e);
        public void LoadGridData();
        public void AddWordButtonClick(object sender, EventArgs e);
    }
}
