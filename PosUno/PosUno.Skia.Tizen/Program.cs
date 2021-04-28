using Tizen.Applications;

using Uno.UI.Runtime.Skia;

namespace PosUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new PosUno.App(), args);
            host.Run();
        }
    }
}
