using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Platformer
{
    public class Collidable
    {
        #region Fields

		protected BoundingBox boundingBox = new BoundingBox();
		public BoundingBox BoundingBox
		{
			get { return boundingBox; }
		}


        #endregion

        #region Member Functions
        public virtual bool CollisionTest(Collidable obj)
        {
			return false;
        }

        public virtual void OnCollision(Collidable obj)
        {
        }
        #endregion


    }
}
