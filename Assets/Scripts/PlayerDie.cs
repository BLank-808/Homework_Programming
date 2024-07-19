using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject End;
    public bool enemy = true;
    private string enemytag = "Enemy";
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == enemytag)
        {
            End.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
