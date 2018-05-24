using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UrMotion;
using Uween;

public class RingController : MonoBehaviour
{

    GameObject bo;
    bool isDoubleTapWait = false;
    bool isUIVisible = false;
    float doubleTapTime = 0f;
    float UItimeout = 5.0f;
    float baseAngle = 0f;
    const int MAX_MENU_ITEMS = 4;
    public Material[] menuMat = new Material[MAX_MENU_ITEMS];
    GameObject prefab;
    GameObject[] menuList = new GameObject[MAX_MENU_ITEMS];
    int itemFocus = 1;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.3f);

        prefab = (GameObject)Resources.Load("Cube");
        bo = GameObject.Find("MenuBase").gameObject;

        //ShowUI(true);

    }


    void ShowUI(bool isVisible)
    {
        if (isVisible) // Show UI
        {
            for (var i = 0; i < MAX_MENU_ITEMS; ++i)
            {
                GameObject g = GameObject.Instantiate(prefab, bo.transform.position, Quaternion.identity);
                g.transform.SetParent(bo.transform);

                g.transform.localPosition = Vector3.zero;
                //g.transform.localScale = Vector3.one;

                g.GetComponent<MeshRenderer>().material = menuMat[i];
                g.name = "Item " + i;
                g.transform.Find("TextArea").gameObject.GetComponent<TextMesh>().text = "menu " + (i+1);

                menuList[i] = g;

                var angle = 90f * (i+1) + 20f;
                var radius = Velocity.AccelByRatio(50f, Source.Constant(0.85f)).Offset(3.0f);
                var speed = Velocity.AccelByRatio(0.75f, Source.Constant(0.94f)).Offset(0.0f);
                g.MotionP().Circular(radius, speed).Angle(angle);
                g.MotionS().Sin(Vector2.one * 0.05f, 0.5f);
            }
            //       Destroy(prefab);
        }
        else // Hide
        {
            for (var i = 0; i < MAX_MENU_ITEMS; ++i)
            {
                //menuList[i].MotionS().AccelByRatio(Vector2.one * 0.0f, 0.85f);

                TweenSXYZ.Add(menuList[i], 0.5f, 0.0f).EaseOutExpo().Then(DeleteMenu);           
            }
        }

        isUIVisible = isVisible;

    }

    void DeleteMenu()
    {
        print("DELETE focus="+itemFocus);
        for (var i = 0; i < MAX_MENU_ITEMS; ++i) 
        {
            if (i != (itemFocus-1))
            Destroy(menuList[i]);
        }
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
        if (isDoubleTapWait) // waiting second click?
        {
            doubleTapTime += Time.deltaTime;
            if (doubleTapTime < 0.3f)
            {
                if (Input.GetKeyDown(KeyCode.Space)) // double tap
                {
                    print("double tap!!");
                    if (!isUIVisible) // not yet shown
                    {
                        isDoubleTapWait = false;
                        ShowUI(true);
                        doubleTapTime = 0f;
                    }
                    else
                    {
                        isDoubleTapWait = false;
                        ShowUI(false);
                        doubleTapTime = 0f;
                    }
                }
            }
            else
            {
                //timeout and reset
                isDoubleTapWait = false;
                doubleTapTime = 0f;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space)) // single tap
            {
                if (!isUIVisible) // UI is not shown. Still waiting second tap
                {
                    isDoubleTapWait = true;
                }
                else // UI is already shown. Dismiss UI
                {
                    //ShowUI(false);
                    isDoubleTapWait = true ;
                }
            }
        }



        var speed = Velocity.AccelByRatio(0.75f, Source.Constant(0.94f));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space");
            //ShowUI(true);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            itemFocus++;

            if (itemFocus > MAX_MENU_ITEMS)
            {
                itemFocus = MAX_MENU_ITEMS;
            }

            baseAngle = 90 * (itemFocus-1);
            
            TweenRZ.Add(bo, 0.7f, baseAngle).EaseOutExpo();
            
            RotateMenu(baseAngle);

            print  ("Down. Focus=" + itemFocus + "  angle=" + baseAngle);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            itemFocus--;
            
            if (itemFocus < 1)
            {
                itemFocus = 1;
            }
            baseAngle = 90 * (itemFocus-1);
            TweenRZ.Add(bo, 0.8f, baseAngle).EaseOutExpo();
            RotateMenu(baseAngle);
            print("Up. Focus=" + itemFocus + "  angle=" + baseAngle);
        }
    }

    void RotateMenu(float angle)
    {
        for (var i = 0; i < MAX_MENU_ITEMS; ++i)
        {
             
            TweenRZ.Add(menuList[i], 0.5f, -angle).EaseOutExpo();           
        }
    
    }
}

