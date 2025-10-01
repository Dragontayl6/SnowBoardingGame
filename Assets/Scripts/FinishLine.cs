using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int LayerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == LayerIndex)
        {
            Invoke("ReloadScene", restartDelay);
            //SceneManager.LoadScene(0);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
