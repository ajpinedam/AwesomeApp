using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace AwesomeApp.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new AwesomeApp.App(), args);
		host.Run();
	}
}
}
