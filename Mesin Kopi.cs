using System;
using System.Collections.Generic;
using System.Text;

public enum StatusMesinKopi
{
    OFF,
    STANDBY,
    BREWING,
    MAINTENANCE
}

public class MesinKopi
{
    private StatusMesinKopi _status = StatusMesinKopi.OFF;
    public StatusMesinKopi Status
    {
        get => _status;
        set => _status = value;
    }

    public MesinKopi() { }

    public void UbahStatusMesin(StatusMesinKopi statusBaru)
    {
        if (!isStatusAvailable(statusBaru))
        {
            Console.WriteLine("Perubahan state tidak valid");
            return;
        }

        string statusLama = Status.ToString();
        if(Status != statusBaru)
        {
            Status = statusBaru;
            Console.WriteLine($"Mesin { statusLama } berubah menjadi { statusBaru }");
        } else
        {
            Console.WriteLine("Perubahan state tidak valid");
        }

    }

    private bool isStatusAvailable(StatusMesinKopi status)
    {
        switch (status)
        {
            case StatusMesinKopi.OFF:
                break;
            case StatusMesinKopi.STANDBY:
                break;
            case StatusMesinKopi.BREWING:
                break;
            case StatusMesinKopi.MAINTENANCE:
                break;
            default:
                return false;
                break;
        }
        return true;
    }
}