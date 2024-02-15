using UnityEngine;

public class ButtonPromptManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform[] signTransforms; 
    public GameObject[] promptObjects; 
    public float activationDistance = 200f;

    void Update()
    {
        for (int i = 0; i < signTransforms.Length; i++)
        {
            float distance = Vector2.Distance(playerTransform.position, signTransforms[i].position);
            if (distance <= activationDistance)
            {
                promptObjects[i].SetActive(true);
            }
            else
            {
                promptObjects[i].SetActive(false);
            }
        }
    }
}
