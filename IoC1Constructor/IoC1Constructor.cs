using System;

namespace IoC1Constructor
{
    class IoC1Constructor
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            FileWriter fileWriter = new FileWriter();
            MailNotification mailNotification = new MailNotification();
            PidgeonNotification pidgeonNotification = new PidgeonNotification();

            WorkingRobot workingRobot = new WorkingRobot(database, fileWriter, mailNotification, pidgeonNotification);
            workingRobot.Work();
        }

        public class WorkingRobot
        {
            private readonly Database _database;
            private readonly FileWriter _fileWriter;
            private readonly MailNotification _mailNotification;
            private readonly PidgeonNotification _pidgeonNotification;

            public WorkingRobot(Database database, FileWriter fileWriter, MailNotification mailNotification, PidgeonNotification pidgeonNotification )
            {
                _database = database;
                _fileWriter = fileWriter;
                _mailNotification = mailNotification;
                _pidgeonNotification = pidgeonNotification;
            }
            public void Work()
            {
                bool isABadThingUsingAnimalsForSendingMessages = true;

                _database.Select();
                _fileWriter.Write();
                _database.UpdateChanges();
                if (isABadThingUsingAnimalsForSendingMessages)
                {
                    _mailNotification.SendNotification();
                }
                else
                {
                    _pidgeonNotification.SendNotification();
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
}
