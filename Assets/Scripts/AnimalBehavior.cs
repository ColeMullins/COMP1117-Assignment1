using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class AnimalBehavior : MonoBehaviour
{
    public TMP_Text Text;
    int number;
    string name;
    private void update() 
    {
        ButtonPromptManager button = GetComponent<ButtonPromptManager>();
        Animal[] animal = { new Moose(), new Gorilla(), new Tortoise(), new Monkey() };
        if (button.getNumber(number)>=0)
        {
            Text.text = "animal Name:" + animal[number].animalName(name); "Amount:" + animal[number].animalAmount() + "Description" + animal[number].animalDescription() + "Sound" + animal[number].animalSound();
        }
    }

}





public interface IInteractable
{
    void animalInteract();
}

public interface IFeedable
{
    void FeedAnimal();
}

// Abstract Base Class
public abstract class Animal
{
    public abstract int animalAmount(int animalAmount);
    public abstract void animalName(string name);
    public abstract string animalDescription(string description);
    public abstract string animalSound(string sound);
}

public class Moose : Animal
{
    public void Interact()
    {
        Debug.Log("Moose is being interacted with!");
    }

    public void FeedAnimal()
    {
        Debug.Log("Moose has been fed!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 4;
    }

    public override void animalName(string name)
    {
        name = "Moose (Meese)";
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

    public void FeedAnimal()
    {
        Debug.Log("Gorilla has been fed!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 4;
    }

    public override void animalName(string name)
    {
        name =  "Silverback Gorilla";
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

    public void FeedAnimal()
    {
        Debug.Log("Tortoise has been fed!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 5;
    }

    public override void animalName(string name)
    {
        name = "Tortoise";
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

    public void FeedAnimal()
    {
        Debug.Log("Monkey has been fed!");
    }

    public override int animalAmount(int animalAmount)
    {
        return 6;
    }

    public override void animalName(string name)
    {
        name = "Monkeys";
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