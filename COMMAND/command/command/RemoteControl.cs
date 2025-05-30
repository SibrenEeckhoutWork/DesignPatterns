using command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RemoteControl
{
    private readonly List<ICommand> _commandHistory = new List<ICommand>();
    private int _currentCommandIndex = -1;

    public void SetAndExecuteCommand(ICommand command)
    {
        // Als we in de geschiedenis zitten en een nieuw commando uitvoeren, moeten we alles na dit punt verwijderen
        if (_currentCommandIndex < _commandHistory.Count - 1)
        {
            _commandHistory.RemoveRange(_currentCommandIndex + 1, _commandHistory.Count - (_currentCommandIndex + 1));
        }

        // Voeg het nieuwe commando toe en voer het uit
        _commandHistory.Add(command);
        command.Execute();
        _currentCommandIndex++;
    }

    public void Undo()
    {
        if (_currentCommandIndex >= 0)
        {
            _commandHistory[_currentCommandIndex].Undo();
            _currentCommandIndex--;
        }
        else
        {
            Console.WriteLine("No commands to undo.");
        }
    }

    public void Redo()
    {
        if (_currentCommandIndex < _commandHistory.Count - 1)
        {
            _currentCommandIndex++;
            _commandHistory[_currentCommandIndex].Execute();
        }
        else
        {
            Console.WriteLine("No commands to redo.");
        }
    }
}
