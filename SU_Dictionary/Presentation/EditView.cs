using SU_Dictionary.Presentation.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU_Dictionary.Presentation
{
    public partial class EditView : Form, IEditView
    {
        private EditPresenter presenter;
        public EditView()
        {
            InitializeComponent();

        }

        public void End()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            this.InitializeComponent();
            presenter.OnStart();
            //throw new NotImplementedException();
        }

        private void EditView_Load(object sender, EventArgs e)
        {

        }

        //Нажание на кнопку [Сохранить]
        public void SaveButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //Внести изменения через презентер!!!! и вернуться в главное окно
        }
        //Нажание на кнопку [Удалить]
        public void DeleteButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //Удалить перевод в модели через презентер!!!! и вернуться в главное окно
        }
    }
}
