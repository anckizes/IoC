using System;

namespace IoC2Setter
{
    class IoC2Setter
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            FileWriter fileWriter = new FileWriter();
            Notification notification;
            bool isABadThingUsingAnimalsForSendingMessages = true;
            WorkingRobot workingRobot = new WorkingRobot();
            
            workingRobot.database = database;
            workingRobot.fileWriter = fileWriter;

            if (isABadThingUsingAnimalsForSendingMessages)
            {
                workingRobot.notification = new MailNotification();
            }
            else
            {
                workingRobot.notification = new PidgeonNotification();
            }
            
            workingRobot.Work();
        }
        
        public class WorkingRobot
        {
            public Database database { get; set; }
            public File fileWriter { get; set; }
            public Notification notification { get; set; }

            public void Work()
            {
                if (database == null)
                throw new Exception("Database cannot be null!");
                
                if (fileWriter == null)
                throw new Exception("File cannot be null!");
                
                if (notification == null)
                throw new Exception("Notification cannot be null!");


                database.Select();
                fileWriter.Write();
                database.UpdateChanges();
                notification.SendNotification();
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

