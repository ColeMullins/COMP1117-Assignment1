using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class AnimalBehavior : MonoBehaviour
{
    public Animal[] animals; 
   
    int AniNumber;
    string AniName;

    public TMP_Text textBox;
    public GameObject textBoxPanel;
    public float interactionDistance = 200f; 
    public KeyCode interactKey = KeyCode.E;
    public float displayDuration = 10f;
    private GameObject[] pillars;
    public GameObject[] feedingBox;

    private Coroutine displayCoroutine;

    void Start()
    {

        pillars = GameObject.FindGameObjectsWithTag("Pillar");
        animals = new Animal[]
        {
            new Moose(),
            new Gorilla(),
            new Tortoise(),
            new Monkey()
        };

        textBox.gameObject.SetActive(false);
        textBoxPanel.SetActive(false);
    }

    void Update()
    {

        foreach (GameObject pillar in GameObject.FindGameObjectsWithTag("Pillar"))
        {
            HandleInteraction(pillar);
        }


        foreach (GameObject feedingBox in GameObject.FindGameObjectsWithTag("FeedingBox"))
        {
            HandleInteraction(feedingBox);
        }

    }

    void HandleInteraction(GameObject interactableObject)
    {
        
        float distance = Vector2.Distance(transform.position, interactableObject.transform.position);

        if (distance <= interactionDistance && Input.GetKeyDown(interactKey))
        {
            IInteractable interactable = interactableObject.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.AnimalInteract();
            }
        }
    }
    public void DisplayInformation(string information)
    {
        textBox.gameObject.SetActive(true);
        textBoxPanel.SetActive(true);

        textBox.text = information;

        if (displayCoroutine != null)
            StopCoroutine(displayCoroutine);

        displayCoroutine = StartCoroutine(TurnOffTextBoxAfterDelay());
    }

    private IEnumerator TurnOffTextBoxAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);

        textBox.gameObject.SetActive(false);
        textBoxPanel.SetActive(false);
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
