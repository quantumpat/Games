using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Core
{
	public class EngineConfig
	{

		/*
		 * Variables
		 */
		private Engine engine = null;

		private bool autoApplyChanges = false;

		private int width = 1280;
		private int height = 720;

		private String title = null;
		private String description = null;
		private String author = null;
		private String version = null;

		private bool mouseVisible = true;

		private bool pixelArt = true;


		/*
		 * Constructors
		 */
		public EngineConfig() {}

		public EngineConfig(Engine engine)
		{

			//Set basic fields
			this.engine = engine;
		
		}

		public EngineConfig(Engine engine, int width, int height)
		{

			//Set basic fields
			this.engine = engine;

			this.width = width;
			this.height = height;

		}

		public EngineConfig(ref Engine engine, int width, int height, String title)
		{

			//Set basic fields
			this.engine = engine;

			this.width = width;
			this.height = height;
			this.title = title;

		}


		/*
		 * Methods
		 */

		/// <summary>
		/// <para>Applies the changes in the config.</para>
		/// </summary>
		public void ApplyChanges()
		{

			//Make sure a game variable exists before trying to apply changes
			if (engine == null) return;

			engine.Graphics.PreferredBackBufferWidth = width;
			engine.Graphics.PreferredBackBufferHeight = height;

			//Set the fields
			engine.IsMouseVisible = mouseVisible;

			engine.Window.Title = title;

			if (pixelArt) engine.GraphicsDevice.SamplerStates[0] = SamplerState.PointClamp;
			else engine.GraphicsDevice.SamplerStates[0] = SamplerState.LinearClamp;

		}


		/*
		 * Getters & Setters
		 */
		public bool AutoApplyChanges
		{
			get { return autoApplyChanges; }
			set { autoApplyChanges = value; }
		}

		public int Width
		{
			get { return width; }
			set
			{
				
				width = value;
				if (autoApplyChanges) ApplyChanges();
			
			}
		}

		public int Height
		{
			get { return height; }
			set
			{
				
				height = value;
				if (autoApplyChanges) ApplyChanges();
			
			}
		}

		public String Title
		{
			get { return title; }
			set
			{

				title = value;
				if (autoApplyChanges) ApplyChanges();

			}
		}

		public String Description
		{
			get { return description; }
			set
			{

				description = value;
				if (autoApplyChanges) ApplyChanges();

			}
		}

		public String Author
		{
			get { return author; }
			set
			{

				author = value;
				if (autoApplyChanges) ApplyChanges();

			}
		}

		public String Version
		{
			get { return version; }
			set
			{

				version = value;
				if (autoApplyChanges) ApplyChanges();

			}
		}

		public bool IsMouseVisible
		{
			get { return mouseVisible; }
			set
			{

				mouseVisible = value;
				if (autoApplyChanges) ApplyChanges();

			}
		}

		public bool IsPixelArt
		{
			get { return pixelArt; }
			set
			{
				pixelArt = value;
				if (autoApplyChanges) ApplyChanges();
			}
		}

	}
}
