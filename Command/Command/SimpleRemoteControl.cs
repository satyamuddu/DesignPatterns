// See https://aka.ms/new-console-template for more information
using Command;

internal class SimpleRemoteControl
{
	ICommand slot;  // only one button

	public void setCommand(ICommand command)
	{
		// set the command the remote will
		// execute
		slot = command;
	}

	public void ButtonWasPressed()
	{
		slot.Execute();
	}
}