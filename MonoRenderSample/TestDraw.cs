using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;
using System;
using System.ComponentModel;

namespace MonoRenderSample
{
    public class TestDraw : MonoGameControl
    {
        [Browsable(false)]
        public string TestString = string.Empty;

        [Browsable(false)]
        public Action UpdateNodeContext { get; set; }

        [Browsable(false)]
        public Vector2 SinSpeed { get; set; }
        [Browsable(false)]
        public Vector2 SinRange { get; set; }

        [Browsable(false)]
        public NodeColor BackGroundColor
        {
            get { return new NodeColor(Editor.BackgroundColor.R, Editor.BackgroundColor.G, Editor.BackgroundColor.B, Editor.BackgroundColor.A); }
            set { Editor.BackgroundColor = new Color(value.SetColor.R, value.SetColor.G, value.SetColor.B, value.SetColor.A); }
        }

        [Browsable(false)]
        public NodeColor DefaultBackGroundColor { get; set; }

        Vector2 position;

        protected override void Initialize()
        {
            base.Initialize();

            SinSpeed = new Vector2(1.5f, 2f);
            SinRange = new Vector2(50, 50);

            DefaultBackGroundColor = new NodeColor(Editor.BackgroundColor.R, Editor.BackgroundColor.G, Editor.BackgroundColor.B, Editor.BackgroundColor.A);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            position = new Vector2(
                ((Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(TestString).X / 2)) + SinScale(gameTime, SinSpeed.X).X * SinRange.X,
                (Editor.graphics.Viewport.Height / 2) - (Editor.Font.MeasureString(TestString).Y / 2) + SinScale(gameTime, SinSpeed.Y).Y * SinRange.Y);

            UpdateNodeContext?.Invoke();
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            //Text
            Editor.spriteBatch.DrawString(Editor.Font, TestString, position, Color.Yellow);

            Editor.spriteBatch.End();

            Editor.DrawDisplay();
        }

        public Vector2 SinScale(GameTime gameTime, float speed)
        {
            if (gameTime != null)
            {
                float time = (float)gameTime.TotalGameTime.TotalSeconds * speed;

                float x = (float)Math.Cos(time);
                float y = (float)Math.Sin(time);
                return new Vector2(x, y);
            }
            return Vector2.Zero;
        }
    }
}
