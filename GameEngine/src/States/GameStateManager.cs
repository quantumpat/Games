using GameEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.States
{
	public class GameStateManager
	{

		/*
		 * Variables
		 */
		private Engine engine;
		private ArrayList states;
		private GameState currentState = null;


		/*
		 * Constructors
		 */
		public GameStateManager(Engine engine)
		{

			this.engine = engine;
			this.states = new ArrayList();

		}


		/*
		 * Methods
		 */
		public void Add(GameState state)
		{

			states.Add(state);

		}

		public void Update(GameTime gameTime)
		{

			if (currentState != null)
				currentState.Update(gameTime);

		}

		public void Draw(GameTime gameTime, SpriteBatch batch)
		{

			if (currentState != null)
				currentState.Draw(gameTime, batch);

		}


		/*
		 * Getters & Setters
		 */
		public Engine Engine
		{
			get { return engine; }
		}

		public ArrayList GameStates
		{
			get { return states; }
		}

		public GameState CurrentState
		{
			get { return currentState; }
		}

	}
}
