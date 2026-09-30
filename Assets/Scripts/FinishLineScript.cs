using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    [SerializeField] float WinRestartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", WinRestartDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}