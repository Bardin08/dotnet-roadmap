﻿namespace Assignment1.Core;

internal record LeaderboardRecord(
    string Player,
    int Wins = 0,
    int Loses = 0,
    int Draws = 0);