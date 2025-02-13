using GameEngine.Core;
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
		 * Getters & Setters
		 */
		public Engine Engine
		{
			get { return engine; }
		}

		public GameState CurrentState
		{
			get { return currentState; }
		}

	}
}
