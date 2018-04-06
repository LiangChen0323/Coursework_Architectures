using System;
using Microsoft.Xna.Framework.Input;
namespace Platformer.Input
                    
{
	public class KeyboardEventArgs : EventArgs
	{
		#region Properties
		public readonly KeyboardState CurrentState;
		public readonly KeyboardState PrevState;
		public readonly Keys Key;
		#endregion

		#region Constructor
		public KeyboardEventArgs(Keys key, KeyboardState currentKeyboardState, KeyboardState prevKeyboardState)
		{
			CurrentState = currentKeyboardState;
			PrevState = prevKeyboardState;
			Key = key;
		}
		#endregion 
	}
}
