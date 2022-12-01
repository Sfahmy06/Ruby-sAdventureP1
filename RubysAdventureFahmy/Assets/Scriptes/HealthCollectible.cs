using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyControllerController controller = other.GetComponent<RubyController>();

        if (controller.ChangeHealth(1);
        Destroy(gameObject);
    }
}