using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class AnimalBehavior : MonoBehaviour
{
    public TMP_Text Text;
    int AniNumber;
    string AniName;

    private void Update()
    {
        ButtonPromptManager button = GetComponent<ButtonPromptManager>();
        Animal[] animal = { new Moose(), new Gorilla(), new Tortoise(), new Monkey() };
        if (button.getNumber(AniNumber) >= 0)
        {
            int amount = animal[AniNumber].AnimalAmount();
            string name = animal[AniNumber].AnimalName();
            string description = animal[AniNumber].AnimalDescription();
            string sound = animal[AniNumber].AnimalSound();

            Text.text = "animal Name:" + name + " Amount:" + amount + " Description:" + description + " Sound:" + sound;
        }
    }
}

public interface IInteractable
{
    void AnimalInteract();
}

public interface IFeedable
{
    void FeedAnimal();
}

// Abstract Base Class
public abstract class Animal
{
    public abstract int AnimalAmount();
    public abstract string AnimalName();
    public abstract string AnimalDescription();
    public abstract string AnimalSound();
}

public class Moose : Animal
{
    public override int AnimalAmount()
    {
        return 4;
    }

    public override string AnimalName()
    {
        return "Moose (Meese)";
    }

    public override string AnimalDescription()
    {
        return "These Moose are large and majestic. They are brown in colour.";
    }

    public override string AnimalSound()
    {
        return "These Moose make a bellowing or roar Sound.";
    }
}

public class Gorilla : Animal
{
    public override int AnimalAmount()
    {
        return 4;
    }

    public override string AnimalName()
    {
        return "Silverback Gorilla";
    }

    public override string AnimalDescription()
    {
        return "These Gorillas are large and hulking. They are black in colour with silver backs.";
    }

    public override string AnimalSound()
    {
        return "These Gorillas make a grunt or grumble sound.";
    }
}

public class Tortoise : Animal
{
    public override int AnimalAmount()
    {
        return 5;
    }

    public override string AnimalName()
    {
        return "Tortoise";
    }

    public override string AnimalDescription()
    {
        return "These Tortoise are small and slow. They are green in colour.";
    }

    public override string AnimalSound()
    {
        return "These Tortoise make a click or croaking sound.";
    }
}

public class Monkey : Animal
{
    public override int AnimalAmount()
    {
        return 6;
    }

    public override string AnimalName()
    {
        return "Monkeys";
    }

    public override string AnimalDescription()
    {
        return "These Monkey are small and curious. They are brown in colour.";
    }

    public override string AnimalSound()
    {
        return "The Monkey make a scream or howl sound.";
    }
}
