using System.Collections.Generic;
using UnityEngine;

namespace BossBattle
{
	using Actions;

	public class Actor : MonoBehaviour
	{
		Queue<IAction> _actionQueue = new Queue<IAction>();

		public void AddAction( EffectAction action, ITarget target )
		{
			action.Initialize( target );
			_actionQueue.Enqueue( action );
		}

		public void AddAction( MoveAction action )
		{
			action.Initialize();
			_actionQueue.Enqueue( action );
		}

		public void Execute()
		{
			while (_actionQueue.Count > 0) {
				var action = _actionQueue.Dequeue();
				Debug.Log( $"{gameObject.name} executing action: '{action.Name}'" );
			}
		}
	}
}
