using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletShoot;
    public bool CanS = true;
    private const float timer = 0.5f;
    private float coundown = .5f;
    private void Update()
    {
        if (CanS == false)
        {
            coundown -= Time.deltaTime;
            if (coundown < 0 ) { CanS = true; coundown = timer; }
        }
        if (Input.GetKeyUp(KeyCode.Mouse0) && CanS)
        {
            GameObject bullet = Instantiate(preFab,bulletShoot.position,Quaternion.identity);
            bullet.transform.SetParent(bulletTrash);
            CanS = false;

        }
    }
}
