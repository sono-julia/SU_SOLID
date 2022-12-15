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
        private MainPresenter presenter = new MainPresenter(this);
        //почему ключевое слово this неприменимо в текущем контексте?

        public MainView()
        {
            InitializeComponent();
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
    }
}
