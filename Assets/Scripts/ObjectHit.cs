using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private bool hasHit = false;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasHit)
            return;

        if (collision.gameObject.CompareTag("Player"))
        {
            hasHit = true;

            // Change obstacle color to red
            if (objectRenderer != null)
            {
                objectRenderer.material.color = Color.red;
            }

            // Tell GameManager a hit occurred
            GameManager.Instance.AddHit();
        }
    }
}