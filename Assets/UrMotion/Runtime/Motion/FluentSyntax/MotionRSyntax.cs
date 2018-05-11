using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;
	using MotionBehaviourVec2 = MotionBehaviour<Vector2>;
	using MotionBehaviourVec3 = MotionBehaviour<Vector3>;

	public static class MotionRSyntax
	{
		public static MotionBehaviourVec1 MotionRX(this GameObject g)
		{
			return UrMotion.MotionRX.Add(g);
		}

		public static MotionBehaviourVec1 MotionRY(this GameObject g)
		{
			return UrMotion.MotionRY.Add(g);
		}

		public static MotionBehaviourVec1 MotionRZ(this GameObject g)
		{
			return UrMotion.MotionRZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionRXY(this GameObject g)
		{
			return UrMotion.MotionRXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionRXZ(this GameObject g)
		{
			return UrMotion.MotionRXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionRYZ(this GameObject g)
		{
			return UrMotion.MotionRYZ.Add(g);
		}

		public static MotionBehaviourVec3 MotionRXYZ(this GameObject g)
		{
			return UrMotion.MotionRXYZ.Add(g);
		}

		public static MotionBehaviourVec1 MotionWRX(this GameObject g)
		{
			return UrMotion.MotionWRX.Add(g);
		}

		public static MotionBehaviourVec1 MotionWRY(this GameObject g)
		{
			return UrMotion.MotionWRY.Add(g);
		}

		public static MotionBehaviourVec1 MotionWRZ(this GameObject g)
		{
			return UrMotion.MotionWRZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionWRXY(this GameObject g)
		{
			return UrMotion.MotionWRXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionWRXZ(this GameObject g)
		{
			return UrMotion.MotionWRXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionWRYZ(this GameObject g)
		{
			return UrMotion.MotionWRYZ.Add(g);
		}

		public static MotionBehaviourVec3 MotionWRXYZ(this GameObject g)
		{
			return UrMotion.MotionWRXYZ.Add(g);
		}

		public static MotionBehaviourVec1 MotionR(this GameObject g)
		{
			return UrMotion.MotionR.Add(g);
		}

		public static MotionBehaviourVec3 MotionR3(this GameObject g)
		{
			return UrMotion.MotionR3.Add(g);
		}

		public static MotionBehaviourVec1 MotionWR(this GameObject g)
		{
			return UrMotion.MotionWR.Add(g);
		}

		public static MotionBehaviourVec3 MotionWR3(this GameObject g)
		{
			return UrMotion.MotionWR3.Add(g);
		}
	}
}