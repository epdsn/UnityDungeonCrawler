using UnityEngine;

public class Player : MonoBehaviour
{

    public string playerName = "Bob the hero";
    public int age = 25;
    public int characterLevel = 80;
    public float moveSpeed = 2.5f; // in units per second
    public bool gameOver = false;
    public Rigidbody rb;
    public int currentHp = 100;


    private void Start()
    {
        TakeDamage(25);
    }
    private void TakeDamage(int damage)
    {
        currentHp = currentHp - damage;
    }

}
