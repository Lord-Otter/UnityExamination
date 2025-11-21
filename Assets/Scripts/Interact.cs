using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private bool insideTrigger = false;

    [SerializeField] GameObject interactText;
    
    void Awake()
    {
        interactText.SetActive(false);
    }

    void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("CaveScene");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            insideTrigger = true;
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            insideTrigger = false;
            interactText.SetActive(false);
        }
    }
}
