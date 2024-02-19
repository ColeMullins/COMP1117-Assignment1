using UnityEngine;

public class ButtonPromptManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform[] signTransforms; 
    public GameObject[] promptObjects; 
    public float activationDistance = 200f;
    public int animalnumber;
    public int getNumber(int number)
    {
        return animalnumber;
    }
    void Update()
    {
        animalnumber = -1;
        for (int i = 0; i < signTransforms.Length; i++)
        {
            float distance = Vector2.Distance(playerTransform.position, signTransforms[i].position);
            if (distance <= activationDistance)
            {
                promptObjects[i].SetActive(true);
                animalnumber = i;
            }
            else
            {
                promptObjects[i].SetActive(false);
            }
        }
    }
}
