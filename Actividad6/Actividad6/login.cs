using System;
using Xamarin.Forms;

namespace Actividad6
{
	public class Login: ContentPage
	{
		public Login ()
		{
			Entry usuario = new Entry { Placeholder = "Usuario" };
			Entry clave = new Entry { Placeholder = "Clave", IsPassword = true };

			Button boton = new Button {
				Text = "Login",
				TextColor = Color.White,
				BackgroundColor = Color.FromHex ("77D065") 
			};

			boton.Clicked += (sender, e) => {
				if (usuario.Text.Length.  clave.Text.Length)
					usuario.Text.Equals("XAMARIN"). clave.Equals("XAMARIN"); {
					usuario.TextColor = Color.Red;
					clave.TextColor = Color.Red;
					string url = "http://212.47.237.211/login"; 
					string result = String.Empty; 
					await contentPage.DisplayAlert("Respuesta del servidor",response, "no es el usuario");
				} else {
					usuario.TextColor = Color.Green;
					clave.TextColor = Color.Green;
					this.Navigation.PushAsync(new newpage());
					Navigation.PushAsync(new newpage()); 

				}
			};

			usuario.TextChanged += (sender, args) => {
				usuario.TextColor = Color.Black;
				clave.TextColor = Color.Black;
			};

			clave.TextChanged += (sender, args) => {
				usuario.TextColor = Color.Black;
				clave.TextColor = Color.Black;
			};


			StackLayout stackLayout = new StackLayout
			{
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					usuario,
					clave,
					boton
				}
				};


			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}
