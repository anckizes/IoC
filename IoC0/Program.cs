using System;

namespace IoC0
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingRobot workingRobot = new WorkingRobot();
            workingRobot.Work();
        }
    }

    public class WorkingRobot
    {
        public void Work()
        {
            Database database = new Database();
            FileWriter fileWriter = new FileWriter();
            MailNotification mailNotification = new MailNotification();
            PidgeonNotification pidgeonNotification = new PidgeonNotification();
            bool isABadThingUsingAnimalsForSendingMessages = true;

            database.Select();
            fileWriter.Write();
            database.UpdateChanges();
            if (isABadThingUsingAnimalsForSendingMessages)
            {
                mailNotification.SendNotification();
            }
            else
            {
                pidgeonNotification.SendNotification();
            }
        }
    }

    public class Database
    {
        public void UpdateChanges()
        {
            Console.WriteLine("Bz-bzz. Data updated!");
        }

        public void Select()
        {
            Console.WriteLine("Bbbzbzbzbz-zz. Data loaded!");
        }
    }

    public class FileWriter
    {
        public void Write()
        {
            Console.WriteLine("Bz-booom. File saved!");
        }
    }

    public interface Notification
    {
        void SendNotification();
    }

    public class MailNotification : Notification
    {
        public void SendNotification()
        {
            Console.WriteLine("Bz Mail Sent bzzzz!");
        }

    }

    public class PidgeonNotification : Notification
    {
        public void SendNotification()
        {
            Console.WriteLine("Bz Pombo Sent bzzzz!");
        }

    }
}
