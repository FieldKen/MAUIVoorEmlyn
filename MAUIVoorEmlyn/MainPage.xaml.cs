
using Microsoft.Maui.Controls.Shapes;

namespace MAUIVoorEmlyn;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        //LIBRARY
        //Rectangle  MinimumWidthRequest = "100" MinimumHeightRequest = "150" MaximumWidthRequest = "100" MaximumHeightRequest = "150" Fill = "Green" ></ Rectangle
        for (int i = 0; i < 50; i++)
        {
            Rectangle rect = new Rectangle();
            rect.MinimumWidthRequest = 100;
            rect.MinimumHeightRequest = 150;
            rect.MaximumWidthRequest = 100;
            rect.MaximumHeightRequest = 150;
            rect.Fill = Brush.Green;
            MijnFlexLayout.Children.Add(rect);
        }


        //MAIN PAGE
        /*for (int i = 0; i < 10; i++)
		{
            Grid grid = new Grid();
            grid.AddColumnDefinition(new ColumnDefinition(GridLength.Star));
            grid.AddColumnDefinition(new ColumnDefinition(GridLength.Auto));
            grid.Margin = new Thickness(10);

            Rectangle rect = new Rectangle();
            rect.MinimumWidthRequest = 50;
            rect.MinimumHeightRequest = 50;
            rect.Fill = Brush.Red;
            Grid.SetColumn(rect, 0);

            Label label = new Label();
            label.FontSize = 36;
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.Text = "PRICES";
            Grid.SetColumn(label, 1);

            grid.Children.Add(rect);
            grid.Children.Add(label);

            GameList.Children.Add(grid);
        }*/
    }
}

