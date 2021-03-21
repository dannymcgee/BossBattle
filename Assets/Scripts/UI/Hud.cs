using UnityEngine;

namespace BossBattle.UI
{
	using UnityEngine.UI;

	public class Hud : MonoBehaviour
	{
		public GameObject ActionButtonPrefab;
		public Player Player { get; private set; }

		public void SetPlayer( Player player )
		{
			Player = player;
			var buttonGroup = GetComponentInChildren<HorizontalLayoutGroup>().gameObject;

			// Clear existing action buttons
			var existingButtons = buttonGroup.GetComponentsInChildren<Button>();
			foreach (var button in existingButtons) {
				Destroy( button.gameObject );
			}

			// Create a button for each player action
			foreach (var action in Player.Actions) {
				var button = Instantiate( ActionButtonPrefab, buttonGroup.transform );
				button.GetComponentInChildren<ActionButton>().Action = action;
			}
		}
	}
}
