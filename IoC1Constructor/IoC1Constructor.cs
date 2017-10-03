using System;

namespace IoC1Constructor
{
    class IoC1Constructor
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            FileWriter fileWriter = new FileWriter();
            Notification notification;
            bool isABadThingUsingAnimalsForSendingMessages = true;
            
            if (isABadThingUsingAnimalsForSendingMessages)
            {
                notification = new MailNotification();
            }
            else
            {
                notification = new PidgeonNotification();
            }


            WorkingRobot workingRobot = new WorkingRobot(database, fileWriter, notification);
            workingRobot.Work();
        }

        public class WorkingRobot
        {
            private readonly Database _database;
            private readonly FileWriter _fileWriter;
            private readonly Notification _notification;

            public WorkingRobot(Database database, FileWriter fileWriter, Notification notification)
            {
                _database = database;
                _fileWriter = fileWriter;
                _notification = notification;
            }
            public void Work()
            {
                

                _database.Select();
                _fileWriter.Write();
                _database.UpdateChanges();
                _notification.SendNotification();
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
}
