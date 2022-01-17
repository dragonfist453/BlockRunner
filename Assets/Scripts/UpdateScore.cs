using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + (int)player.position.z/10;
    }
}
