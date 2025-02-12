
using GameEngine.GameObjects;

public class Program
{
	public static void Main(string[] args)
	{
		
		var engine = new GameEngine.Core.Engine();
		engine.Config.AutoApplyChanges = true;
		engine.Run();

		Sprite sprite = new Sprite(engine.GameObjects, "cosmos-bg", 0, 0);

	}
}