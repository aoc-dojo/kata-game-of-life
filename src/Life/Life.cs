﻿using Life;

var board = Board.Random();
Console.WriteLine("State 0");
board.Print();

board.Evolve();
Console.WriteLine("State 1");
board.Print();
