namespace CommandExampleB
{
    internal class RobotController
    {
        public Queue<IRobotCommand> commands;
        private Stack<IRobotCommand> _undoStack;

        public RobotController()
        {
            commands = new Queue<IRobotCommand>();
            _undoStack = new Stack<IRobotCommand>();
        }

        public void ExecuteCommands()
        {
            Console.WriteLine("Executing commands");

            while (commands.Count > 0)
            {
                IRobotCommand comando = commands.Dequeue();
                comando.Execute();
                _undoStack.Push(comando);
            }
        }

        public void UndoCommands(int numUndoCommands)
        {
            Console.WriteLine("Undoing {0} commands.", numUndoCommands);

            while (numUndoCommands > 0 && _undoStack.Count > 0)
            {
                IRobotCommand command = _undoStack.Pop();
                command.Undo();
                numUndoCommands--;
            }
        }
    }
}