using X6Z71T.UI;
using X6Z71T.Helper;
internal class Program
{
    private static void Main(string[] args)
    {

        Ui ui = new Ui(new CommandHelper());
        ui.Run();
    }
}