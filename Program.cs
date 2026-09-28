// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");


// Console.WriteLine($"OC: {Environment.OSVersion}");
// Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");


// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");


Console.WriteLine($"Память процесса (WorkingSet): {Environment.WorkingSet / 1024 / 1024} МБ");
Console.WriteLine($"PID процесса: {Environment.ProcessId}");