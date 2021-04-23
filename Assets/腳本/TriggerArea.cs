
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
 [Header("要關閉的石頭們")]
    public GameObject stone;

    public GameObject[] stones;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "香菇")
        {
            stones[0].SetActive(false);
        }
    }
}
