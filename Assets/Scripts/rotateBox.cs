using UnityEngine;

public class rotateBox : MonoBehaviour
{
    private float xRotate; // These are the values used in our Vector3 Later
    private float yRotate;
    private float zRotate;


    [SerializeField]
    float threshold = 500; // The higher the number, the less often the object will change its rotate values.

    [SerializeField]
    float spinFactor = 4.0f; // Initialization of how quickly the object rotates.

    // Update is called once per frame
    void Update()
    {
        Vector3 boxRotater = new Vector3(xRotate, yRotate, zRotate); // Creating our initial Vector with rotation values.
        transform.Rotate(boxRotater * Time.deltaTime * spinFactor); // The main part of the rotation script.
        Rotate(); 
         
    }

    public void Rotate()
    {
        xRotate = Random.Range(0, 0); // This method is used to change the rotation.
        yRotate = Random.Range(0, 0);
        zRotate = Random.Range(0, 360);
    }

}
