using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FeynmanGame.Models
{
    public class StatusBar
    {
        private SpriteFont messageFont;
        private int timer;
        private int score;
        private string messageString;
        private Vector2 messagePos;
        private Color color;

        public StatusBar(SpriteFont messageFont)
        {
            this.timer = 20;
            this.score = 0;
            this.MessageString = $"Time: {timer} Score: {score}";
            this.messagePos = new Vector2(600, 30);
            this.MessageFont = messageFont;
            this.Color = Color.Coral;
        }

        public SpriteFont MessageFont { get; }
        public string MessageString { get; }
        public Vector2 МessagePos { get; }
        public Color Color { get; }
    }
}
