using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject dot;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(dot, transform.position, Quaternion.identity);
        }
    }
}
