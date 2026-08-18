using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          Renderer carroRender = other.GetComponentInChildren<Renderer>();
            if (carroRender != null )
            {
                carroRender.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); // Change the color of the player's material to a random color
            }
               
         
        }
    }

}
