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
            Vector3 mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);

            Vector2 direction = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);

            transform.right = direction;
        }
             

    }
}
