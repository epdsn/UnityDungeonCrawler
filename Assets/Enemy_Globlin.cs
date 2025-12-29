using UnityEngine;

public class Enemy_Globlin : Enemy
{
    [ContextMenu("Steal Gold")]
    private void Awake()
    {
        enemyName = "Goblin";
        moveSpeed = 2.5f;
    }
    private void StealMoney()
    {
        Debug.Log($"{enemyName} is stealing your gold!");
    }

}
