using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Interface for interactable objects
public interface IInteractable
{
    void Interact();
}

// Abstract Base Class
public abstract class Animal
{
    public abstract int animalAmount(int animalAmount);
    public abstract string animalName(string name);
    public abstract string animalDescription(string description);
    public abstract string animalSound(string sound);
}

// Implementing the IInteractable interface in Moose class
public class Moose : Animal, IInteractable
{
    public void Interact()
    {
        // Implement interaction behavior for Moose
        Debug.Log("Moose is being interacted with!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 4;
    }

    public override string animalName(string name)
    {
        return "Moose (Meese)";
    }

    public override string animalDescription(string description)
    {
        return "These Moose are Large and Majestic, they are Brown.";
    }

    public override string animalSound(string sound)
    {
        return "These Moose make a Bellowing or Roar Sound.";
    }
}

// Implementing the IInteractable interface in Gorilla class
public class Gorilla : Animal, IInteractable
{
    public void Interact()
    {
        // Implement interaction behavior for Gorilla
        Debug.Log("Gorilla is being interacted with!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 4;
    }

    public override string animalName(string name)
    {
        return "Silverback Gorilla";
    }

    public override string animalDescription(string description)
    {
        return "These Gorillas are Large and Hulking, they are Black with Silver backs.";
    }

    public override string animalSound(string sound)
    {
        return "These Gorillas make a Grunt or Grumble Sound.";
    }
}