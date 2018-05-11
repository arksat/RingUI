using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;
	using MotionBehaviourVec2 = MotionBehaviour<Vector2>;
	using MotionBehaviourVec3 = MotionBehaviour<Vector3>;

	public static class MotionSPSyntax
	{
		public static MotionBehaviourVec1 MotionSX(this GameObject g)
		{
			return UrMotion.MotionSX.Add(g);
		}

		public static MotionBehaviourVec1 MotionSY(this GameObject g)
		{
			return UrMotion.MotionSY.Add(g);
		}

		public static MotionBehaviourVec1 MotionSZ(this GameObject g)
		{
			return UrMotion.MotionSZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionSXY(this GameObject g)
		{
			return UrMotion.MotionSXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionSXZ(this GameObject g)
		{
			return UrMotion.MotionSXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionSYZ(this GameObject g)
		{
			return UrMotion.MotionSYZ.Add(g);
		}

		public static MotionBehaviourVec3 MotionSXYZ(this GameObject g)
		{
			return UrMotion.MotionSXYZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionS(this GameObject g)
		{
			return UrMotion.MotionS.Add(g);
		}

		public static MotionBehaviourVec3 MotionS3(this GameObject g)
		{
			return UrMotion.MotionS3.Add(g);
		}
	}
}