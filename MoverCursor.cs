using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCursor : MonoBehaviour
{
    private SpriteRenderer Rend;
    public Sprite Normal, Pulsado;
    private void Start()
    {
        Cursor.visible = false;
        Rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        if(Input.GetMouseButtonDown(0))
        {
            Rend.sprite = Pulsado;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Rend.sprite = Normal;
        }
    }
}
