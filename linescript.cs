using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linescript : MonoBehaviour {

    public LineRenderer linerenderer;
    public EdgeCollider2D edgecol;

    List<Vector2> points;

    public void UpdateLine(Vector2 point)
    {
        print("side UpdateLine");
        if (points == null)
        {
            
            points = new List<Vector2>();
            Debug.Log("points " + points.Count);
            Setpoint(point);
            return;
        }
        // check if mouse has moved eneough point. If yes, add new point
        Vector2 lastpoint = points[points.Count - 1];
        if (Vector2.Distance(lastpoint, point) > 0.5)
        {
            Setpoint(point);
        }
        
    }

    private void Setpoint(Vector2 point)
    {
        points.Add(point);

        //linerenderer.po
        linerenderer.positionCount = points.Count;
        //linerenderer.set
        linerenderer.SetPosition(points.Count-1, point);
        if(points.Count > 1)
            edgecol.points = points.ToArray();
    }
}
