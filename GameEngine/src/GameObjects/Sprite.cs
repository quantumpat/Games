﻿using GameEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
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

		private String textureName = null;
		private Texture2D texture = null;
		private bool visible = false;


		/*
		 * Constructors
		 */
		public Sprite(GameObjectManager manager, String name)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(0, 0);

		}

		public Sprite(GameObjectManager manager, String name, int x, int y)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(x, y);

		}

		public Sprite(GameObjectManager manager, String name, int x, int y, String textureName)
		{

			this.manager = manager;

			this.name = name;

			pos = new Vector2(x, y);

			this.textureName = textureName;
			texture = manager.Engine.Content.Load<Texture2D>(textureName);

		}


		/*
		 * Methods
		 */
		private void Initialize()
		{

			manager.Add(this);

		}

		
		public void Draw(SpriteBatch batch)
		{

			if (!visible) return;

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

		public int X { get { return x; } set { x = value; } }

		public int Y { get { return y; } set { y = value; } }

		public Texture2D GetTexture() { return texture; }

		public void SetTexture(String textureName)
		{
			this.textureName = textureName;
			this.texture = manager.Engine.Content.Load<Texture2D>(textureName);
		}

		public bool Visible
		{ get { return visible; } set { visible = value; } }

	}
}
