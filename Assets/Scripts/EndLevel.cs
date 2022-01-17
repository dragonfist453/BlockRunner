using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public PlayerMovement movement;

    public GameObject CompleteLevelUI;

    void OnTriggerEnter(Collider colliderInfo) {
        if(colliderInfo.GetComponent<Collider>().tag == "Player") {
            movement.enabled = false;
            CompleteLevelUI.SetActive(true);
            Debug.Log("Level Complete");
        }
    }
}
