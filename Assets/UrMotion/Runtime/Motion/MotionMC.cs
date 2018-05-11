﻿using UnityEngine;

namespace UrMotion
{
	public class MotionMA : MotionVec1MC<MotionMA>
	{
		protected override float value {
			get {
				return col.a;
			}
			set {
				var c = col;
				c.a = value;
				col = c;
			}
		}
	}

	public class MotionMC : MotionVec3MC<MotionMC>
	{
		protected override Vector3 value {
			get {
				return new Vector3(col.r, col.g, col.b);
			}
			set {
				var c = col;
				c.r = value.x;
				c.g = value.y;
				c.b = value.z;
				col = c;
			}
		}
	}

	public class MotionMCA : MotionVec4MC<MotionMCA>
	{
		protected override Vector4 value {
			get {
				return (Vector4)col;
			}
			set {
				col = (Color)value;
			}
		}
	}
}