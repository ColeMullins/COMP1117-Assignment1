using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public interface IInteractable
{
    void animalInteract();
}

// Abstract Base Class
public abstract class Animal
{
    public abstract int animalAmount(int animalAmount);
    public abstract string animalName(string name);
    public abstract string animalDescription(string description);
    public abstract string animalSound(string sound);
}

public class Moose : Animal
{
    public void Interact()
    {
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

public class Gorilla : Animal
{
    public void Interact()
    {
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

public class Tortoise : Animal
{
    public void Interact()
    {

        Debug.Log("Tortoise is being interacted with!");
    }
    public override int animalAmount(int animalAmount)
    {
        return 5;
    }

    public override string animalName(string name)
    {
        return "Tortoise";
    }

    public override string animalDescription(string description)
    {
        return "These Tortoise are Small and slow, they are Green.";
    }

    public override string animalSound(string sound)
    {
        return "These Tortoise make a Click or Croaking Sound.";
    }
}

public class Monkey : Animal
{
    public void Interact()
    {
        Debug.Log("Monkey is being interacted with!");
    }
    public override int animalAmount(int animalAmount)
    {
        return 6;
    }

    public override string animalName(string name)
    {
        return "Monkeys";
    }

    public override string animalDescription(string description)
    {
        return "These Monkey are Small and Curious, they are Brown.";
    }

    public override string animalSound(string sound)
    {
        return "The Monkey make a Scream or Howl Sound.";
    }
}