using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWhenTouching : MonoBehaviour
{
    Renderer sprite;
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {

                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(touch.position);
                RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

                if (hit.collider != null)
                {

                    if (isPressed == false)
                    {
                        Debug.Log(hit.collider.name);
                        hit.collider.gameObject.GetComponent<SpriteRenderer>().color = new Color(135, 206, 250);
                        isPressed = true;
                    }
                    else
                    {
                        Debug.Log(hit.collider.name);
                        hit.collider.gameObject.GetComponent<SpriteRenderer>().color = default;
                        isPressed = false;
                    }
                }
            }
        }
    }
}
