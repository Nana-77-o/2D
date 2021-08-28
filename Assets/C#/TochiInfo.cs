using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TochiInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Touchi.Began += onTouchBegan;
        Touchi.Ended += (info) =>
        {
            Debug.Log("ボタンが離された時" + info.screenPoint);
        };
    }

    void onTouchBegan(TouchInfo info)
    {
        Debug.Log("ボタンが押された時" + info.screenPoint);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
