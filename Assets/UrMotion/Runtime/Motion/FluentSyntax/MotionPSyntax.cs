using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;
	using MotionBehaviourVec2 = MotionBehaviour<Vector2>;
	using MotionBehaviourVec3 = MotionBehaviour<Vector3>;

	public static class MotionPSyntax
	{
		public static MotionBehaviourVec1 MotionX(this GameObject g)
		{
			return UrMotion.MotionX.Add(g);
		}

		public static MotionBehaviourVec1 MotionY(this GameObject g)
		{
			return UrMotion.MotionY.Add(g);
		}

		public static MotionBehaviourVec1 MotionZ(this GameObject g)
		{
			return UrMotion.MotionZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionXY(this GameObject g)
		{
			return UrMotion.MotionXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionXZ(this GameObject g)
		{
			return UrMotion.MotionXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionYZ(this GameObject g)
		{
			return UrMotion.MotionYZ.Add(g);
		}

		public static MotionBehaviourVec3 MotionXYZ(this GameObject g)
		{
			return UrMotion.MotionXYZ.Add(g);
		}

		public static MotionBehaviourVec1 MotionWX(this GameObject g)
		{
			return UrMotion.MotionWX.Add(g);
		}

		public static MotionBehaviourVec1 MotionWY(this GameObject g)
		{
			return UrMotion.MotionWY.Add(g);
		}

		public static MotionBehaviourVec1 MotionWZ(this GameObject g)
		{
			return UrMotion.MotionWZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionWXY(this GameObject g)
		{
			return UrMotion.MotionWXY.Add(g);
		}

		public static MotionBehaviourVec2 MotionWXZ(this GameObject g)
		{
			return UrMotion.MotionWXZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionWYZ(this GameObject g)
		{
			return UrMotion.MotionWYZ.Add(g);
		}

		public static MotionBehaviourVec3 MotionWXYZ(this GameObject g)
		{
			return UrMotion.MotionWXYZ.Add(g);
		}

		public static MotionBehaviourVec2 MotionP(this GameObject g)
		{
			return UrMotion.MotionP.Add(g);
		}

		public static MotionBehaviourVec3 MotionP3(this GameObject g)
		{
			return UrMotion.MotionP3.Add(g);
		}

		public static MotionBehaviourVec2 MotionWP(this GameObject g)
		{
			return UrMotion.MotionWP.Add(g);
		}

		public static MotionBehaviourVec3 MotionWP3(this GameObject g)
		{
			return UrMotion.MotionWP3.Add(g);
		}
	}
}