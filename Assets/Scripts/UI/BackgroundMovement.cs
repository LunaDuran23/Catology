using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private Vector2 movementVelocity;

    private Vector2 offset;

    public Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        offset = movementVelocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
