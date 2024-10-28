using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayCastingMouse : MonoBehaviour
{
    [SerializeField] GameObject doomRays;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.point);
                DoomRay doomRay = Instantiate(doomRays, transform.position, Quaternion.identity).GetComponent<DoomRay>();
                doomRay.SetTarget(hit.point);
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
