using TaskHub.Models;

var taskList = new TaskList();
while (true)
{
    taskList
       .Clear()
       .Populate()
       .Execute();

    Thread.Sleep(1000);
}
