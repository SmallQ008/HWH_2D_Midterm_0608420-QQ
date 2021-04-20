
using UnityEngine;

public class player : MonoBehaviour
{
[Header("等級")]
    public int lv = 1;
    [Range(0,300)]
    public float speed = 10.5f;
    public bool isDead = false;
    [Tooltip("這是角色的名稱")]
    public string cName = "貓咪";


    private void Move()
    {

    }

    private void Attack()
    {
 
    }

    private void Hit()
    { 
    
    }

    private void Dead()
    { 
    
    }

}
