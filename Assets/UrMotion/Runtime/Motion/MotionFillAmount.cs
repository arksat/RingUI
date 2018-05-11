using UnityEngine.UI;

namespace UrMotion
{
	public class MotionFillAmount : MotionVec1<MotionFillAmount>
	{
		Image Im;

		protected Image GetImage()
		{
			return Im ?? (Im = GetComponent<Image>());
		}

		protected override float value {
			get {
				return GetImage().fillAmount;
			}
			set {
				GetImage().fillAmount = value;
			}
		}
	}
}