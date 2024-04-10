using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLine : MonoBehaviour
{
    LineRenderer _lineRenderer;
    Krobus _krobus;
    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _krobus = FindObjectOfType<Krobus>();
        Vector3 lineZeroPosition = new Vector3(
            _krobus.transform.position.x,
            _krobus.transform.position.y,
            -0.1f);
        _lineRenderer.SetPosition(0, lineZeroPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (_krobus.IsDragging)
        {
            _lineRenderer.enabled = true;
            _lineRenderer.SetPosition(1, _krobus.transform.position);
        }
        else
        {
            _lineRenderer.enabled = false;
        }
    }
}