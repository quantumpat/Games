using GameEngine.Core;
using GameEngine.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		private GameState state;
		private ArrayList sprites;


		/*
		 * Constructors
		 */
		public GameObjectManager(GameState state)
		{

			this.state = state;

			sprites = new ArrayList(10);

		}


		/*
		 * Methods
		 */
		public void Add(Sprite sprite)
		{

			sprites.Add(sprite);

		}

		public void Update(GameTime gameTime)
		{

			foreach (Sprite sprite in sprites) if (sprite != null) sprite.Update(gameTime);

		}

		public void Draw(GameTime gameTime, SpriteBatch batch)
		{

			foreach (Sprite sprite in sprites) if (sprite != null) sprite.Draw(batch);

		}

		/*
		 * Getters & Setters
		 */
		public GameState State
		{
			get { return state; }
			set
			{
				state = value;
			}
		}

		public ArrayList Sprites
		{
			get { return sprites; }
		}

	}

}
