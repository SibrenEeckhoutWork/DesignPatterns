// Receivers
using command;

Light livingRoomLight = new Light();
Fan ceilingFan = new Fan();

// Concrete Commands
ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);
ICommand fanStart = new FanStartCommand(ceilingFan);
ICommand fanStop = new FanStopCommand(ceilingFan);

// Invoker
RemoteControl remote = new RemoteControl();

// Execute multiple commands
remote.SetAndExecuteCommand(lightOn);
remote.SetAndExecuteCommand(fanStart);
remote.SetAndExecuteCommand(lightOff);
remote.SetAndExecuteCommand(fanStop);

// Undo last two commands
Console.WriteLine("Undoing last command...");
remote.Undo();

Console.WriteLine("Undoing another command...");
remote.Undo();

// Redo last undone command
Console.WriteLine("Redoing last undone command...");
remote.Redo();
