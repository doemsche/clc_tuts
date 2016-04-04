using UnityEngine;
using System.Collections;
namespace Renderering1{
	public class RotationTransformation : Transformation {
		public Vector3 rotation;

		public override Vector3 Apply (Vector3 point) {
			float radZ = rotation.z * Mathf.Deg2Rad;
			float sinZ = Mathf.Sin(radZ);
			float cosZ = Mathf.Cos(radZ);

			return point;
		}
	}
}
