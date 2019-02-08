using UnityEngine;

public class Follow_mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Follow_Mouse();



    }

    // Update is called once per frame
    void Follow_Mouse()
    {
        bool v = gameObject.tag == "Player";

        if (v)
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector2 characterScreenPos = Camera.main.WorldToScreenPoint(transform.GetChild(0).position);
            Vector2 direction = mousePosition - characterScreenPos;

            transform.GetChild(0).localRotation = Quaternion.Euler(transform.GetChild(0).localRotation.eulerAngles.x, -Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg, transform.GetChild(0).localRotation.eulerAngles.z);

        }
             

    }
}
