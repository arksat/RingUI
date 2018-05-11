using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UrMotion;
using Uween;

public class RingController : MonoBehaviour
{

    GameObject bo;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.3f);

        GameObject g = transform.Find("Image").gameObject;
        bo = transform.Find("Base").gameObject;

        // Spiral #2

        GameObject prefab = g;
        for (var i = 0; i < 12; ++i)
        {
            g = GameObject.Instantiate(prefab);
            g.transform.SetParent(bo.transform);
            
 
            //g.transform.SetParent(prefab.transform.parent);

            g.transform.localPosition = Vector3.zero;
            g.transform.localScale = Vector3.one; 

            var angle = 30f * i;
            var radius = Velocity.AccelByRatio(218f, Source.Constant(0.92f)).Offset(83f);
            var speed = Velocity.AccelByRatio(0.75f, Source.Constant(0.94f)).Offset(0.0f);
            g.MotionP().Circular(radius, speed).Angle(angle);
        }
 //       Destroy(prefab);

    }

    Vector2 GetMousePosition()
    {
        var canvas = GetComponent<Canvas>();
        var sp = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var lp = default(Vector2);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, sp, canvas.worldCamera, out lp);
        return lp;
    }


    void Update()
    {

        var speed = Velocity.AccelByRatio(0.75f, Source.Constant(0.94f));

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow key is held down");
            TweenRZ.Add(bo, 0.7f, 90f).EaseOutExpo();
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            TweenRZ.Add(bo, 0.8f, 180f).EaseOutExpo();

            print("down arrow key is held down");
        }
    }
}

