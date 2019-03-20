using System;
using System.Windows.Forms;
using TDDWinform.Presenter;
using TDDWinform.View;

namespace TDDWinform
{
    public partial class MainForm : Form, IRectangleView
    {
        RectanglePresenter rectPresenter;

        public double Length
        {
            get
            {
                return double.Parse(TextBoxLength.Text);
            }

            set
            {
                TextBoxLength.Text = value.ToString();
            }
        }

        public double Breadth
        {
            get
            {
                return double.Parse(TextBoxBreadth.Text);
            }

            set
            {
                TextBoxBreadth.Text = value.ToString();
            }
        }

        public double Area
        {
            get
            {
                return double.Parse(TextBoxArea.Text);
            }

            set
            {
                TextBoxArea.Text = value.ToString();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rectPresenter = new RectanglePresenter(this);
        }

        private void ButtonCalculateArea_Click(object sender, EventArgs e)
        {
            rectPresenter.CalculateArea();
        }
    }
}
