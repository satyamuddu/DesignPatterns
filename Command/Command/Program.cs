// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
SimpleRemoteControl remote =
				 new SimpleRemoteControl();
Light light = new Light();

// we can change command dynamically
remote.setCommand(new
			LightOnCommand(light));
remote.ButtonWasPressed();
remote.setCommand(new
			LightOffCommand(light));
remote.ButtonWasPressed();