using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour, IInteractable
{
    public int animalIndex; // Index of the animal in the Animal array

    public void AnimalInteract()
    {
        // Get the Animal array from the AnimalBehavior script
        Animal[] animals = FindObjectOfType<AnimalBehavior>().animals;

        // Ensure the index is within bounds
        if (animalIndex >= 0 && animalIndex < animals.Length)
        {
            Animal animal = animals[animalIndex];

            // Get information about the animal from the assigned scriptable object
            int amount = animal.AnimalAmount();
            string name = animal.AnimalName();
            string description = animal.AnimalDescription();
            string sound = animal.AnimalSound();

            // Find the AnimalBehavior script and call DisplayInformation method to update the UI
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