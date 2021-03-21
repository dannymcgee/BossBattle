using System.Collections.Generic;

namespace BossBattle.Actions
{
	using System.Linq;
	using UnityEngine;

	public static class Library
	{

		public static IReadOnlyList<IAction> Attacks { get; }
		public static IReadOnlyList<IAction> Heals { get; }
		public static IReadOnlyList<MoveAction> Moves { get; }

		public static IReadOnlyList<IAction> Actions { get; } = new IAction[] {
			// Attacks
			new EffectAction(
				name: "Attack1",
				cost: 1,
				strength: 1,
				type: EffectType.Damage
			),
			new EffectAction(
				name: "Attack2",
				cost: 3,
				strength: 3,
				type: EffectType.Damage
			),
			new EffectAction(
				name: "Attack3",
				cost: 5,
				strength: 5,
				type: EffectType.Damage
			),
			// Heals
			new EffectAction(
				name: "Heal1",
				cost: 1,
				strength: 1,
				type: EffectType.Heal
			),
			new EffectAction(
				name: "Heal2",
				cost: 3,
				strength: 3,
				type: EffectType.Heal
			),
			new EffectAction(
				name: "Heal3",
				cost: 5,
				strength: 5,
				type: EffectType.Heal
			),
			// Movement
			new MoveAction(
				name: "Move Up",
				cost: 1,
				delta: Vector2Int.up
			),
			new MoveAction(
				name: "Move Right",
				cost: 1,
				delta: Vector2Int.right
			),
			new MoveAction(
				name: "Move Down",
				cost: 1,
				delta: Vector2Int.down
			),
			new MoveAction(
				name: "Move Left",
				cost: 1,
				delta: Vector2Int.left
			),
		};

		static Library()
		{
			Attacks = Actions
				.OfType<EffectAction>()
				.Where( a => a.Type == EffectType.Damage )
				.ToList();

			Heals = Actions
				.OfType<EffectAction>()
				.Where( a => a.Type == EffectType.Heal )
				.ToList();

			Moves = Actions.OfType<MoveAction>().ToList();
		}
	}
}
