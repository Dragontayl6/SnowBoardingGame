using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int LayerIndex = LayerMask.NameToLayer("floor");

        if (collision.gameObject.layer == LayerIndex)
        {
            SceneManager.LoadScene(0);
        }


    }    

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
