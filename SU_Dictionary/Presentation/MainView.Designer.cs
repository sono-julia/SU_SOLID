using SU_Dictionary.Presentation;
using SU_Dictionary.Presentation.Api;

namespace SU_Dictionary
{
    partial class MainView : IMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MainPresenter presenter = new MainPresenter(this);
        //почему ключевое слово this неприменимо в текущем контексте?

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
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}