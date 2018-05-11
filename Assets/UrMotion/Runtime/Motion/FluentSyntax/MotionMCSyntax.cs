using UnityEngine;

namespace UrMotion
{
	using MotionBehaviourVec1 = MotionBehaviour<float>;
	using MotionBehaviourVec2 = MotionBehaviour<Vector2>;
	using MotionBehaviourVec3 = MotionBehaviour<Vector3>;
	using MotionBehaviourVec4 = MotionBehaviour<Vector4>;

	public static class MotionMCSyntax
	{
		public static MotionBehaviourVec1 MotionMA(this GameObject g)
		{
			return UrMotion.MotionMA.Add(g);
		}

		public static MotionBehaviourVec3 MotionMC(this GameObject g)
		{
			return UrMotion.MotionMC.Add(g);
		}

		public static MotionBehaviourVec4 MotionMCA(this GameObject g)
		{
			return UrMotion.MotionMCA.Add(g);
		}
	}
}