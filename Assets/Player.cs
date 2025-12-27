using UnityEngine;

public class Player : MonoBehaviour
{

    public string playerName = "Bob the hero";
    public int age = 25;
    public float moveSpeed = 2.5f; // in units per second
    public bool gameOver = false;
    public Rigidbody rb;
    public void Start()
    {
        Debug.Log("Player name is: "  + playerName);
    }



}
