using GameEngine.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameObjects
{
	public class GameObjectManager
	{

		/*
		 * Variables
		 */
		private Engine engine;
		//private ArrayList<Sprite> sprites;


		/*
		 * Constructors
		 */
		public GameObjectManager(Engine engine)
		{

			this.engine = engine;

		}


		/*
		 * Getters & Setters
		 */
		public Engine Engine { get { return engine; } }

	}

}
