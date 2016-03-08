using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()

		{    
			return new ContentPage { 
				Content = new Label {
					Text = "TE CLEA EL BOTON Y TE DARA EL NOMBRE DEL ALUMNO!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,


				},
			};
		}
	}
}	
public class ButtonLoggerPage : ContentPage
{
	
	StackLayout loggerLayout = new StackLayout(); 
	public ButtonLoggerPage()
	{ 
		Button button = new Button 
		{
			Text = "TECLEA EL BOTÓN!"
		}; 
		button.Clicked += OnButtonClicked; 
		this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0); 

	}
	void OnButtonClicked(object sender, EventArgs args)
	{
		 
		loggerLayout.Children.Add(new Label
			{ Text = "SERGIO CESAR  RUIZ  SANTANA" 
			}); 
	}
}
	