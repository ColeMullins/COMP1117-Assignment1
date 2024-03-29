using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour, IInteractable
{
    public int animalIndex; 

    public void AnimalInteract()
    {
        Animal[] animals = FindObjectOfType<AnimalBehavior>().animals;

        if (animalIndex >= 0 && animalIndex < animals.Length)
        {
            Animal animal = animals[animalIndex];

            int amount = animal.AnimalAmount();
            string name = animal.AnimalName();
            string description = animal.AnimalDescription();
            string sound = animal.AnimalSound();

            AnimalBehavior animalBehavior = FindObjectOfType<AnimalBehavior>();
            if (animalBehavior != null)
            {
                animalBehavior.DisplayInformation("Animal Name: " + name + "\nAmount: " + amount + "\nDescription: " + description + "\nSound: " + sound);
            }
        }
        else
        {
            Debug.LogWarning("Oopsie Daisy");
        }
    }
}