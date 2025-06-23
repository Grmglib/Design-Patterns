namespace CommandExampleB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Robot robot = new Robot();
            RobotController controller = new RobotController();

            MoveCommand move = new MoveCommand(1000, robot);
            controller.commands.Enqueue(move);

            RotateCommand rotate = new RotateCommand(45, robot);
            controller.commands.Enqueue(rotate);

            ExcavateCommand excavate = new ExcavateCommand(true, robot);
            controller.commands.Enqueue(excavate);

            controller.ExecuteCommands();
            controller.UndoCommands(3);

            Console.ReadKey();
        }
    }
}