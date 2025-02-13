using GameEngine.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.States
{
	public class GameState
	{

		/*
		 * Variables
		 */
		private String name = null;
		private GameObjectManager gameObjects;


		/*
		 * Constructors
		 */
		public GameState(String name)
		{

			this.name = name;
			gameObjects = new GameObjectManager(this);

		}


		/*
		 * Methods
		 */
		public void Update(GameTime gameTime)
		{

			gameObjects.Update(gameTime);

		}

		public void Draw(GameTime gameTime, SpriteBatch batch)
		{
			gameObjects.Draw(gameTime, batch);
		}


		/*
		 * Getters & Setters
		 */
		public String Name
		{
			get { return name; }
			set
			{
				name = value;
			}
		}

		public GameObjectManager GameObjects
		{
			get { return gameObjects; }
		}

	}

}
