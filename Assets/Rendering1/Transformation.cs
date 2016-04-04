using UnityEngine;
namespace Renderering1{
	public abstract class Transformation : MonoBehaviour {
		public abstract Vector3 Apply(Vector3 point);
	}
}

