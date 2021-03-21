using UnityEngine;

namespace BossBattle
{
	public class Board : MonoBehaviour
	{
		public Vector2Int Size;
		public GameObject PrefabTile;

		Camera _camera;

		void Awake()
		{
			_camera = Camera.main;
		}

		void Start()
		{
			var cameraPos = _camera.transform.position;
			var cameraX = (float) Size.x / 2;
			var cameraY = (float) Size.y / 2;
			_camera.transform.position =
				new Vector3( cameraX, cameraY, cameraPos.z ) - new Vector3( 0.5f, 0.5f );
			_camera.orthographicSize = (float) Size.y / 2;

			for (var x = 0; x < Size.x; x++) {
				for (var y = 0; y < Size.y; y++) {
					var cell = Instantiate( PrefabTile, transform );
					var pos = new Vector2( x, y );
					cell.transform.position = pos;
				}
			}
		}
	}
}
