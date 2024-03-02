namespace FirstApp;

public class StartPage : ContentPage
{
	public StartPage()
	{
		string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n" +
                "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                "x:Class=\"HelloApp.StartPage\">\n" +
                "<Label x:Name=\"header\" Text=\"Hello METANIT.COM\" FontSize=\"22\" />" +
                "</ContentPage>";

        this.LoadFromXaml(pageXAML);
		Label header = this.FindByName<Label>("header");
		header.Text = ".NET MAUI on METANIT.COM";
  //      Content = new VerticalStackLayout
		//{
		//	Children = {
		//		new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
		//		}
		//	}
		//};

		//Content = new Label() { Text = "Hello METANIT.COM!" };
	}
}