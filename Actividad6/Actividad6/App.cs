using System; 
using Xamarin.Forms;  

 namespace Actividad6 
 { 
 	public class App 
 	{ 
 		public static Page GetMainPage () 
 		{	 
 			return new NavigationPage (new Login()); 
 		} 
 	} 
 } 
 