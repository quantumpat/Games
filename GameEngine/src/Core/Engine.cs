using GameEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameEngine.GameObjects;
using System.Diagnostics;
using GameEngine.States;

namespace GameEngine.Core
{
	public class Engine : Game
	{

		/*
		 * Variables
		 */
		private EngineConfig config;
		private GraphicsDeviceManager graphics;
		private SpriteBatch spriteBatch;
		private GameStateManager stateManager;


		/*
		 * Constructors
		 */
		public Engine()
		{

			config = new EngineConfig(this);

			Boot();

		}

		public Engine(EngineConfig config)
		{

			this.config = config;

			Boot();

		}


		/*
		 * Methods
		 */
		private void Boot()
		{

			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			stateManager = new GameStateManager(this);

		}

		protected void Initialize()
		{

			base.Initialize();

		}

		protected override void LoadContent()
		{

			config.ApplyChanges();

			spriteBatch = new SpriteBatch(GraphicsDevice);

		}

		protected override void Update(GameTime gameTime)
		{
			
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			if (stateManager.CurrentState != null)
				stateManager.CurrentState.Update(gameTime);

			base.Update(gameTime);

		}

		protected override void Draw(GameTime gameTime)
		{

			GraphicsDevice.Clear(Color.Black);

			spriteBatch.Begin();

			if (stateManager.CurrentState != null)
				stateManager.CurrentState.Draw(gameTime, spriteBatch);

			spriteBatch.End();

			base.Draw(gameTime);

		}


		/*
		 * Getters & Setters
		 */
		public EngineConfig Config
		{
			get { return config; }
		}

		public GraphicsDeviceManager Graphics
		{ get { return graphics; } }

		public SpriteBatch SpriteBatch
		{
			get { return spriteBatch; }
		}

		public GameStateManager StateManager
		{
			get { return stateManager; }
		}

	}
}
