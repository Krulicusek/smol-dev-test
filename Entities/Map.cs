using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace TowerDefense.Entities
{
    public class Map
    {
        private Texture2D texture;
        private Vector2 position;
        private string mapFilePath = "map.txt";
        private int[,] mapLayout;

        public Map(ContentManager content)
        {
            texture = content.Load<Texture2D>("Content/Textures/Map.png");
            LoadMap();
        }

        private void LoadMap()
        {
            string[] mapData = File.ReadAllLines(mapFilePath);
            int width = mapData[0].Length;
            int height = mapData.Length;

            mapLayout = new int[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mapLayout[y, x] = int.Parse(mapData[y][x].ToString());
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int y = 0; y < mapLayout.GetLength(0); y++)
            {
                for (int x = 0; x < mapLayout.GetLength(1); x++)
                {
                    position = new Vector2(x * texture.Width, y * texture.Height);
                    spriteBatch.Draw(texture, position, Color.White);
                }
            }
        }
    }
}