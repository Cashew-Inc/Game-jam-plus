using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMachine : MonoBehaviour
{
    public Canvas interactionCanvas; 
    public string sceneToLoad;
    private bool isNearMachine = false; 
    void Start()
    {
        interactionCanvas.enabled = false;
    }

    void Update()
    {
        if (isNearMachine && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearMachine = true;
            interactionCanvas.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearMachine = false;
            interactionCanvas.enabled = false;
        }
    }
}
