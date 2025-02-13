using GameEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameObjects
{
	public class Sprite
	{

		/*
		 * Variables
		 */
		private GameObjectManager manager = null;
		private String name = null;

		private Vector2 pos;

		private Texture2D texture = null;
		private bool visible = true;


		/*
		 * Constructors
		 */
		public Sprite(GameObjectManager manager, String name)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(0, 0);

			Initialize();

		}

		public Sprite(GameObjectManager manager, String name, int x, int y)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(x, y);

			Initialize();

		}

		public Sprite(GameObjectManager manager, String name, int x, int y, Texture2D texture)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(x, y);

			this.texture = texture;

			Initialize();

		}


		/*
		 * Methods
		 */
		private void Initialize()
		{

			manager.Add(this);

		}

		public void Update(GameTime gameTime)
		{
		}

		public void Draw(SpriteBatch batch)
		{

			if (!visible || texture == null) return;
			batch.Draw(texture, pos, Color.White);

		}


		/*
		 * Getters & Setters
		 */
		public GameObjectManager Manager { get { return manager; } }

		public String Name {
			get { return name; }
			set { name = value; }
		}

		public float X { get { return pos.X; } set { pos.X = value; } }

		public float Y { get { return pos.Y; } set { pos.Y = value; } }

		public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

		public bool Visible
		{ get { return visible; } set { visible = value; } }

	}
}
