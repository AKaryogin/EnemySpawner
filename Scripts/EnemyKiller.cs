using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePositionToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePositionToWorld, Vector3.forward);

            if(hit.collider != null)
            {
                Destroy(hit.transform.gameObject);                
            }
            
        }
    }
}
