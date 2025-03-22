using Unity.VisualScripting;
using UnityEngine;


public class NoteMove : MonoBehaviour
{
    Transform fretboard;
    void Start() {
        fretboard = GameObject.Find("Fretboard").transform;
    }

    float velocity = 1;

    void FixedUpdate()
    {
        transform.Translate(Time.fixedDeltaTime * velocity * Vector3.back);

        //print(fretboard.localScale.z / 2 * 10);
        //print(transform.position);
        if (transform.position.z <= fretboard.position.z - (fretboard.localScale.z / 2 * 10)) {
            print("Passed!");
        }
    }
}
