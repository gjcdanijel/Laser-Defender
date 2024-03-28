using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStarColor : MonoBehaviour
{
    public Color newColor;
    private SpriteRenderer rend;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = newColor;
    }
}
