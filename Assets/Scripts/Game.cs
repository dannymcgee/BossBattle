using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossBattle
{
	using UI;

	public class Game : MonoBehaviour
	{
		public Player ActivePlayer { get; private set; }

		Hud _hud;

		void Start()
		{
			_hud = FindObjectOfType<Hud>();
			ActivePlayer = FindObjectOfType<Player>();
			_hud.SetPlayer( ActivePlayer );
		}
	}
}
