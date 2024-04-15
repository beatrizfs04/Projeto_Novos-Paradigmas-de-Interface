using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Sprite defaultNoteSprite;
    new Transform transform;

    [Tooltip("Rotation speed of the sprite")]
    [SerializeField]
    [Range(0.0f, 10.0f)]
    float rotationSpeed = 5.0f;

    [Tooltip("Falling speed of the rigidbody")]
    [SerializeField]
    [Range(0.0f, 10.0f)]
    float speed = 5.0f;

    [Tooltip("List of sprites that the notes will randomly pick")]
    [SerializeField]
    Sprite[] sprites;

    bool creatorMode = false;

    public void setCreatorMode(bool active)
    {
        creatorMode = active;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultNoteSprite = spriteRenderer.sprite;
        transform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0, -speed);
        spriteRenderer.sprite = GetRandomSprite();
        if (creatorMode) spriteRenderer.sprite = defaultNoteSprite;

    }

    Sprite GetRandomSprite()
    {
        if (sprites.Length < 1) return spriteRenderer.sprite;

        return sprites[Random.Range(0, sprites.Length - 1)];
    }

    private void FixedUpdate()
    {
        transform.Rotate(0.0f, 0.0f, 1f * rotationSpeed, Space.Self);
        if (creatorMode) transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
