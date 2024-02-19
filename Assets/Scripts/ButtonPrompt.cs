using UnityEngine;

public class ButtonPromptManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform[] signTransforms; 
    public Transform[] BoxTransforms; 
    public GameObject[] promptObjects; 
    public float activationDistanceForSigns = 200f;
    public float activationDistanceForBox = 100f;
    public int animalnumber;

    public int GetNumber(int number)
    {
        return animalnumber;
    }

    void Update()
    {
        animalnumber = -1;

     
        for (int i = 0; i < signTransforms.Length; i++)
        {
            float distance = Vector2.Distance(playerTransform.position, signTransforms[i].position);
            if (distance <= activationDistanceForSigns)
            {
                promptObjects[i].SetActive(true);
                animalnumber = i;
            }
            else
            {
                promptObjects[i].SetActive(false);
            }
        }

       
        for (int i = 0; i < BoxTransforms.Length; i++)
        {
            float distance = Vector2.Distance(playerTransform.position, BoxTransforms[i].position);
            if (distance <= activationDistanceForBox)
            {
                int index = i + signTransforms.Length;
                promptObjects[index].SetActive(true);
                animalnumber = index;
            }
            else
            {
                int index = i + signTransforms.Length;
                promptObjects[index].SetActive(false);
            }
        }
    }
}
