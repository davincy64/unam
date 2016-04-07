using System; 
using Xamarin.Forms; 

namespace Actividad7 
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

 			this.Content = stackLayout; 
 			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5); 
 		} 
 	} 
} 
