﻿var myapp = new Run();
//myapp.startApp();
Thread Th1 = new Thread(new ThreadStart(myapp.ServerOverlay));
Thread Th2 = new Thread(new ThreadStart(myapp.ConsoleReader));
Th1.Start();
Th2.Start();