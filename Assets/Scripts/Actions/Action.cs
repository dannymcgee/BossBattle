using UnityEngine;

namespace BossBattle.Actions
{
	public enum EffectType
	{
		Damage,
		Heal,
	}

	public interface ITarget
	{
		Vector2 Position { get; }
		int Health { get; set; }
	}

	public interface IAction
	{
		public string Name { get; }
		public int Cost { get; }
	}

	public class EffectAction : IAction
	{
		public string Name { get; }
		public int Cost { get; }
		public EffectType Type { get; }
		public int Strength { get; }
		public ITarget Target { get; private set; }

		public EffectAction(
			string name,
			int cost,
			EffectType type,
			int strength )
		{
			Name = name;
			Cost = cost;
			Type = type;
			Strength = strength;
		}

		public void Initialize( ITarget target )
		{
			Target = target;
		}
	}

	public class MoveAction : IAction
	{
		public string Name { get; }
		public int Cost { get; }
		public Vector2Int Delta { get; }

		public MoveAction( string name, int cost, Vector2Int delta )
		{
			Name = name;
			Cost = cost;
			Delta = delta;
		}

		public void Initialize() {}
	}

}
