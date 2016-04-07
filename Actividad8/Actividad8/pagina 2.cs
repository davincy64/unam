using System; 
using Xamarin.Forms; 

namespace Actividad8 
{ 
	public class Pagina2: ContentPage 
	{ 
		public Pagina2 () 
		{ 
			Label texto = new Label { 
				Text = "Página 2", 
				TextColor = Color.Blue 
			}; 

			StackLayout stackLayout = new StackLayout 
			{ 
				Children = 
				{ 
					texto  

				} 
				}; 
			
			var uri3 = new Uri("https://www.google.com.mx/imgres?imgurl=http://www.educacionyculturaaz.com/wp-content/uploads/2013/07/Escudo-UNAM-A.jpg&imgrefurl=http://www.educacionyculturaaz.com/educacion/convoca-unam-a-formar-coleccion-de-libros-digitales&h=640&w=1024&tbnid=obD65tKAlOIcNM:&docid=tyDdHI65hkhjzM&ei=QYwEV-_7OOOwjgSB0qSADQ&tbm=isch&ved=0ahUKEwivoKSpkvnLAhVjmIMKHQEpCdAQMwhGKB0wHQ"); 
			var uri4 = new Uri("https://www.google.com.mx/imgres?imgurl=https://pbs.twimg.com/profile_images/616985983863525376/zCFU4CM0.jpg&imgrefurl=https://twitter.com/fundacion_unam&h=512&w=512&tbnid=4oGM3A_K2qm6PM:&docid=65mQO7tRdEm1uM&ei=kYwEV76fIIWDjgTs7qSIBg&tbm=isch&ved=0ahUKEwj-q57PkvnLAhWFgYMKHWw3CWE4ZBAzCC8oKjAq"); 

			var image = new Image { Aspect = Aspect.AspectFit }; 

			image.Source = ImageSource.FromUri(uri3);
			image.Source = ImageSource.FromUri(uri4);


			this.Content = stackLayout; 
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5); 
		} 
	} 
} 
