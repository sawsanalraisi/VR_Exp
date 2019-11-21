using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LineRender : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform point3;

    public LineRenderer LineRenderer;
    public int vertexCount = 12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pointList = new List<Vector3>();

        for (float ratio = 0; ratio <= 1; ratio += 1.0f / vertexCount)
        {
            var tangentLineVectex1 = Vector3.Lerp(point1.position, point2.position, ratio);
            var tangentLineVectex2 = Vector3.Lerp(point2.position, point3.position, ratio);
            var bezierpoint = Vector3.Lerp(tangentLineVectex1, tangentLineVectex2, ratio);
            pointList.Add(bezierpoint);
            
        }
        LineRenderer.positionCount = pointList.Count;

        LineRenderer.SetPositions(pointList.ToArray());

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(point1.position, point2.position);
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(point2.position, point3.position);

        Gizmos.color = Color.red;
        //float ratio = 0.25f;

        for (float ratio = 0.25f / vertexCount; ratio < 1; ratio += 1.0f / vertexCount)
        {
            Gizmos.DrawLine(Vector3.Lerp(point1.position, point2.position, ratio), Vector3.Lerp(point2.position, point3.position, ratio));
        }
    }
}
