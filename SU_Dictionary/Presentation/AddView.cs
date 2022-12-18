using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU_Dictionary.Presentation.Api;

namespace SU_Dictionary.Presentation
{
    public partial class AddView : Form, IAddView
    {
        private AddPresenter presenter;
        public AddView()
        {
            InitializeComponent();
        }

        private void AddView_Load(object sender, EventArgs e)
        {

        }

        public void Start()
        {
            this.InitializeComponent();
            presenter.OnStart();
            //throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }
        //Нажание на кнопку [Добавить]
        public void AddButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //Добавить перевод через презентер!!!! и вернуться в главное окно
        }
    }
}
