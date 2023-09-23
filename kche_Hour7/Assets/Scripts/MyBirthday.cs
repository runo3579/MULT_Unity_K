using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Define your birthday month and day here
   
    private int birthdayMonth = 9;  // Change this to your birthday month (e.g., 1 for January, 2 for February, etc.)
   
    private int birthdayDay = 23;  // Change this to your birthday day
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Loop through months from 1 to 12
        for (int month = 1; month <= 12; month++)
        {
            // Check if it's your birthday month
            if (month == birthdayMonth)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(month);
            }
        }

        // Loop through days of the birthday month
        if(birthdayMonth==2)
        {
            count = 28;
        }
        else
        {
            count = 31;
        }
        for (int day = 1; day <= count; day++)
        {
            // Check if it's your birthday day
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add update logic here if needed
    }
}