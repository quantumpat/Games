
public class Program
{
	public static void Main(string[] args)
	{
		
		var engine = new GameEngine.Core.Engine();
		engine.Config.AutoApplyChanges = true;
		engine.Run();

	}
}