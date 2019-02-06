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
            Vector3 characterScreenPos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 direction = mousePosition - characterScreenPos;
            
            transform.right = direction;

        }
             

    }
}
