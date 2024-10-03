using System.Diagnostics;

/*
 * Different ways to get a lot of plusses and minusses in the console.
 */

const int repetitions = 1000;

// UseSystemThreading();
// UseSystemThreadingTasks();
UseAsync();

static void UseSystemThreading()
{
    // Create thread and associate method
    ThreadStart threadStart = DoWork;    // ThreadStart Delegate
    Thread plusThread = new Thread(threadStart);
    // Start thread
    plusThread.Start();
    //
    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }
    // Wait for plusThread to terminate
    plusThread.Join();
}

static void DoWork()
{
    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('+');
    }
}

static void UseSystemThreadingTasks()
{
    // Create and run Task
    Task plusTask = Task.Run(
        () => {
            for (int count = 0; count < repetitions; count++)
            {
                Console.Write('+');
            }

        }
    );

    Debug.WriteLine("Plus Task status: " + plusTask.Status);

    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }

    plusTask.Wait();
    Debug.WriteLine("Plus Task status: " + plusTask.Status);
}

// The job of the UseAsync method is to display minuses while the job of the DoWorkAsync method is to display plusses.
// Minusses
static async void UseAsync()
{
    // 1. Call DoWorkAsync()
    var doWorkTask = DoWorkAsync();
    // 2. Print minuses
    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }

    // Wait for the async work to complete
    await doWorkTask;
}

// Plusses
static async Task DoWorkAsync()
{
    // Start code:
    await Task.Run(() => {
        for (int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }
    });
}
