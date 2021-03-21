using UnityEngine;

namespace BossBattle.UI
{
	using Actions;
	using UnityEngine.UI;

	public class ActionButton : MonoBehaviour
	{
		IAction _action;
		public IAction Action {
			get => _action;
			set {
				_action = value;
				GetComponentInChildren<Text>().text = _action.Name;
			}
		}
	}
}
