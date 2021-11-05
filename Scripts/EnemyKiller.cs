using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(difference, Vector3.forward);

            if(hit.collider != null)
            {
                Destroy(hit.transform.gameObject);                
            }
            
        }
    }
}
