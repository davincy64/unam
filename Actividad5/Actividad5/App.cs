using System; 
using Xamarin.Forms;  

namespace Actividad5
{ 
	public class App 
 	{ 
 		public static Page GetMainPage () 
 		{	 
 			return new NavigationPage (new Login()); 
 		} 
 	} 
 } 
 