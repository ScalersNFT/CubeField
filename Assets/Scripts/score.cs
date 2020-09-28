
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text textScore;
    
    void Update()
    {
        textScore.text = player.position.z.ToString("0");
    }
}
