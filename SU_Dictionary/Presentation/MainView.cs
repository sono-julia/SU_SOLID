using SU_Dictionary.Presentation;
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

namespace SU_Dictionary
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;
        //почему ключевое слово this неприменимо в текущем контексте?

        public MainView()
        {
            presenter = new MainPresenter(this);
            //InitializeComponent();

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        public void Start()
        {
            this.InitializeComponent();
            presenter.OnStart();
        }

        public void Show(string message)
        {
            //как отобразить?
        }

        public void ShowError(Exception e)
        {
            //куда вывести ошибку?
        }

        //Нажатие на слово (?)
        private void EditWord(object sender, EventArgs e)
        {
            EditView editView= new EditView();
            editView.Start(); //Открываем окно с изменением слова
        }

        public void LoadGridData()
        {
            throw new NotImplementedException();
        }
        //Нажатие на кнопку [+]
        public void AddWordButtonClick(object sender, EventArgs e) 
        {
            AddView addView = new AddView();
            addView.Start(); //Открываем окно с добавлением слова
            
        }
    }
}
