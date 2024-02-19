using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingBox : MonoBehaviour, IInteractable
{
    public int animalIndex;

    public void AnimalInteract()
    {
        
        Animal[] animals = FindObjectOfType<AnimalBehavior>().animals;

        
        if (animalIndex >= 0 && animalIndex < animals.Length)
        {
            Animal animal = animals[animalIndex];

            string name = animal.AnimalName();

            
            AnimalBehavior animalBehavior = FindObjectOfType<AnimalBehavior>();
            if (animalBehavior != null)
            {
                animalBehavior.DisplayInformation("The " + name + " are now fed");
            }
        }
        else
        {
            Debug.LogWarning("Oopsie Daisy");
        }
    }
}
