using System; 
using Xamarin.Forms; 
using Java; 
using Org.Apache.Http.Entity; 
using Org.Apache.Http.Client; 
using Org.Apache.Http.Client.Entity; 
using Org.Apache.Http.Client.Methods; 
using Org.Apache.Http.Client.Params; 
using Org.Apache.Http.Client.Protocol; 
using Org.Apache.Http.Client.Utils; 
using Org.Apache.Http.Message; 
using Org.Apache.Http.Auth; 
using Org.Apache.Http.Authentication; 
using Org.Apache.Http.Cookies; 
using Org.Apache.Http.Cookie; 
using Org.Apache.Http.Conn; 
using Org.Apache.Http.IO; 
using Org.Apache.Http.Impl; 
using Org.Apache.Http.Protocol; 
using Org.Apache.Http.Params; 
using Org.Apache.Http.Util;  

 namespace Actividad5 
 { 
 	public class Contenido: ContentPage 
 	{ 
 		public Contenido () 
 		{ 
 			Entry entry = new Entry { Placeholder = "Ok En Conexión" }; 
 			Label filenameLabel = new Label{Text="Error"}; 
			string url = "http://104.42.52.205/mobile/login"; 
 			string result = String.Empty; 
 			DefaultHttpClientConnection cliente = new DefaultHttpClientConnection(); 
 			HttpPost posteo = new HttpPost (url); 
 			try{ 
				
		} 
 			catch (Exception exc){  
			 
			filenameLabel.Text = exc.Message;

 			}; 
 		} 
 	} 
 }  
	