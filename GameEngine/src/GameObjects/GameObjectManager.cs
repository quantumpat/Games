using GameEngine.Core;
using Microsoft.Xna.Framework.Graphics;
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
		private ArrayList sprites;


		/*
		 * Constructors
		 */
		public GameObjectManager(Engine engine)
		{

			this.engine = engine;

			sprites = new ArrayList();

		}

		
		/*
		 * Methods
		 */
		public void Add(Sprite sprite)
		{

			sprites.Add(sprite);

		}

		public void Draw(SpriteBatch batch)
		{

			foreach (Sprite sprite in sprites) if (sprite != null) sprite.Draw(batch);

		}

		/*
		 * Getters & Setters
		 */
		public Engine Engine { get { return engine; } }

	}

}
