using System; 
using Xamarin.Forms; 

 namespace Actividad7 
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
			
 			this.Content = stackLayout; 
 			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5); 
 		} 
 	} 
 } 
