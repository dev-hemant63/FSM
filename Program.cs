using FSM.Repository;

class Program
{
    static void Main(string[] args)
    {
        DatabaseBackupStateMachine fsm = new DatabaseBackupStateMachine();

        fsm.RequestBackup();

        Console.ReadLine();
    }
}
