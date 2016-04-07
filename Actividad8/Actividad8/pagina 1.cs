using System; 
using Xamarin.Forms; 

namespace Actividad8 
{ 
	public class Pagina1: ContentPage 
	{ 
		public Pagina1 () 
		{ 
			Label texto = new Label { 
				Text = "Página 1", 
				TextColor = Color.Blue
			}; 

			Button boton = new Button 
			{ 
				Text = " Navegar en la página2" 
			}; 

			boton.Clicked += (sender, e) => { 
				this.Navigation.PushAsync(new Pagina2()); 
			}; 

			StackLayout stackLayout = new StackLayout 
			{ 
				Children = 
				{ 
					texto, 
					boton 


				}
				}; 
			var uri = new Uri("https://www.google.com.mx/search?q=fotos+unam&biw=1366&bih=599&tbm=isch&imgil=vLae-78WzBBQSM%253A%253Be4i4D3-rnD4hEM%253Bhttp%25253A%25252F%25252Fmexicoenergetico.com.mx%25252Funam-y-cfe-planean-desarrollar-en-conjunto-proyectos-en-materia-energetica%25252F&source=iu&pf=m&fir=vLae-78WzBBQSM%253A%252Ce4i4D3-rnD4hEM%252C_&usg=__QANMYfQidT1dwKrJZrdGx8nGOLc%3D"); 
			var uri2 = new Uri("https://www.google.com.mx/search?q=fotos+unam&biw=1366&bih=599&tbm=isch&imgil=4DmW4TqzrA3hZM%253A%253B9IWs90_fg3eV2M%253Bhttp%25253A%25252F%25252Fwww.vanguardia.com.mx%25252Farticulo%25252Ffuera-de-peligro-mexicanas-que-estudian-en-bruselas-unam&source=iu&pf=m&fir=4DmW4TqzrA3hZM%253A%252C9IWs90_fg3eV2M%252C_&usg=__jyhcRet-qWOtzbthLYOiacsjDoI%3D"); 

			var image = new Image { Aspect = Aspect.AspectFit }; 

			image.Source = ImageSource.FromUri(uri);
			image.Source = ImageSource.FromUri(uri2);



			this.Content = stackLayout; 
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5); 
		} 
	} 
} 
