using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOver;

    public bool collided;

    public bool gameOverFlag = false;

    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            collided = true;
        }
    }

    void Update()
    {
        if(!gameOverFlag && (collided || transform.position.x > 5.5 || transform.position.x < -5.5)) {
            gameOver.text = "GAME OVER";
            gameOverFlag = true;
            Application.Quit();
        }
    }
}
