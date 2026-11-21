using FSCSharp;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BlastyBird
{
    public class Bird : VisibleGameObject
    {
        #region Constructors
        public Bird(Vector2 location)
        {
            Location = location;
            var texture = Raylib.LoadTexture("Resources/Bird.png");
            Body = new Sprite(texture, 2f);

        }
        #endregion

        #region Overrides
        public override void Draw(float delta)
        {
            Body.Draw(Location);
        }

        public override void Update(float delta)
        {
            
        }
        #endregion

        #region Properties
        public Vector2 Location{ get; set;}
        public Sprite Body { get; set; }
        #endregion
    }
}
