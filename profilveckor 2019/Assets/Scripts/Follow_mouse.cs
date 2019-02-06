using UnityEngine;

public class Follow_mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        follow_Mouse();



    }

    // Update is called once per frame
    void follow_Mouse()
    {
        bool v = gameObject.tag == "Player";

        if (v)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            
            transform.right = direction;

        }
             

    }
}
