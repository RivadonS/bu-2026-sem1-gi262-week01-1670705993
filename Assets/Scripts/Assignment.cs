using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0) Debug.Log("Positive");
        else if (as01Number < 0) Debug.Log("Negative");
        else Debug.Log("Zero");
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1: Debug.Log("Monday"); break;
            case 2: Debug.Log("Tuesday"); break;
            case 3: Debug.Log("Wednesday"); break;
            case 4: Debug.Log("Thursday"); break;
            case 5: Debug.Log("Friday"); break;
            case 6: Debug.Log("Saturday"); break;
            case 7: Debug.Log("Tuesday"); break;
            default: Debug.Log("Invalid day"); break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword) Debug.Log("True");
        else Debug.Log("False");
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        throw new System.NotImplementedException();
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        throw new System.NotImplementedException();
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        throw new System.NotImplementedException();
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        throw new System.NotImplementedException();
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        throw new System.NotImplementedException();
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
