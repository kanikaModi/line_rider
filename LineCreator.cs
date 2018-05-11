using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {

    public GameObject linePrefab;
    linescript activeline;
    // Update is called once per frame
    void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject lineRO = Instantiate(linePrefab);
            activeline = lineRO.GetComponent<linescript>();
        }
        if (Input.GetMouseButtonUp(0))
        {
            activeline = null;
        }
            //Vector2
            if (activeline != null)
        {
            print("Mouse Down");
            Vector2 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeline.UpdateLine(point);
        }
    }
}
