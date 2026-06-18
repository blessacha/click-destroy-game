using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // left click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}