using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetectionScript : MonoBehaviour
{
    [SerializeField] float LoseRestartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", LoseRestartDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
