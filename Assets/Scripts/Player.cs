using System.Collections.Generic;
using UnityEngine;

namespace BossBattle
{
	using Actions;

	public class Player : MonoBehaviour
	{
		public List<IAction> Actions { get; private set; }

		void Awake()
		{
			Actions = new List<IAction> {
				Library.Attacks[Random.Range(0, Library.Attacks.Count)],
				Library.Heals[Random.Range(0, Library.Heals.Count)],
			};
			Actions.AddRange( Library.Moves );
		}
	}
}
