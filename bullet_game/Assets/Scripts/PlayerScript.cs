using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private GameObject gun;
    [SerializeField] private Camera camera;

    private Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        gun.transform.position = transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            var gunRb = gun.GetComponent<Rigidbody2D>();
            mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
            var posProb = mousePosition - gunRb.position;
            var angle = Mathf.Atan2(posProb.y, posProb.x) * Mathf.Rad2Deg;
            gunRb.rotation = angle;
        }
    }
}