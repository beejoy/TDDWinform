using TDDWinform.Model;
using TDDWinform.View;

namespace TDDWinform.Presenter
{
    public class RectanglePresenter
    {
        private IRectangleView rectangleView;

        public RectanglePresenter(IRectangleView view)
        {
            rectangleView = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = rectangleView.Length;
            rectangle.Breadth = rectangleView.Breadth;

            rectangleView.Area = rectangle.CalculateArea();
        }
    }
}
